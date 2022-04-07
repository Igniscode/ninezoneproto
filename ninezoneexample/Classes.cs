﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ninezoneexample
{
    class Classes
    {
    }
    class StateProcessManager
    {
        BaseState Base = new BaseState();
        public string Pitcher = "None";
        TeamInformation TopTeam = new TeamInformation("Socks");
        TeamInformation BottomTeam = new TeamInformation("Shoes");
        public int inning = 0;
        public string TopBottom = "Top"; // 현재 공격인 팀
        public string AttackTeam;

        public Queue<string> GameLog = new Queue<string>();
        
        public void InningStart()
        {
            GameLog.Enqueue("<I>" + inning.ToString());  
        }

        public void SetAttackTeam(string tb)
        {
            if (TopBottom == "Top") AttackTeam = TopTeam.Name;
            else if (TopBottom == "Bottom") AttackTeam = BottomTeam.Name;
            GameLog.Enqueue("<T>" + AttackTeam);
        }

        public void SetBatter()
        {
            Base.Batter = getBatterNum();
            GameLog.Enqueue("<B>" + Base.batOrder + "!" + getPlayerName(Base.Batter,TopBottom));
        }
        public void setPitch(PitchClass @class, float velocity, int location)
        {
            GameLog.Enqueue("<P>" + @class.ToString() + "!" + velocity.ToString() + "?" + location);
        }
        public void Pitch(PitchCase @case)
        {
            GameLog.Enqueue("<H>" + @case.ToString());

            switch (@case)
            {
                case PitchCase.STRIKE:
                    Base.S++;
                    break;
                case PitchCase.SWING:
                    Base.S++;
                    break;
                case PitchCase.BALL:
                    Base.B++;
                    break;
                case PitchCase.FOUL:
                    if (Base.S < 2) Base.S++;
                    break;
                case PitchCase.HIT:
                    Base.HitCaseLog();
                    Base.RunorOut();
                    break;
                case PitchCase.BUNT:
                    Base.HitCaseLog();
                    Base.RunorOut();
                    break;
                case PitchCase.HOMERUN:
                    Base.HomeRun();
                    break;
                case PitchCase.HIT_BY_PITCH:
                    Base.HitByPitch();
                    break;
            }
            Base.EndPitch();
        }
        int getBatterNum()
        {
            int ret;
            if (TopBottom == "Top")
            {
                ret = TopTeam.batorder[Base.batOrder];
            }
            else
            {
                ret = BottomTeam.batorder[Base.batOrder];
            }
            return ret;
        }
        public string getPlayerName(int number, string topbottom)
        {
            string ret;
            if (topbottom == "Top")
            {
                ret = TopTeam.players[number];
            }
            else
            {
                ret = BottomTeam.players[number];
            }
            return ret;
        }


        public void Accident(AccidentCase @case)
        {
            switch (@case)
            {
                case AccidentCase.PICKOFF:
                    break;
                case AccidentCase.STEAL:
                    break;
            }
        }
        class TeamInformation
        {
            public string Name = "None";
            public int Score = 0;
            public Dictionary<int, string> players = new Dictionary<int, string>();
            public Dictionary<int, int> batorder = new Dictionary<int, int>();
            public TeamInformation(string name)
            {
                Name = name;
            }
        }

        class BaseState
        {
            int last_1B = 0;
            int last_2B = 0;
            int last_3B = 0;

            public int current_1B = 0;
            public int current_2B = 0;
            public int current_3B = 0;

            public int batOrder = 0;
            public int Batter = 0;

            public int S = 0;
            public int B = 0;
            public int O = 0;

            public bool isBatterout = false;
            public List<int> current_H = new List<int>();//홈인 한 사람
            public List<int> current_O = new List<int>();//아웃 된 사람
            public List<Position> defence = new List<Position>();
            public Queue<TurnEndLog> log = new Queue<TurnEndLog>();

            public void HomeRun() { }
            public void HitByPitch() { }
            public TurnEndLog EndPitch() {
                TurnEndLog ret = TurnEndLog.DEFAULT;
                if (S >= 3)
                {
                    ret = TurnEndLog.STRIKEOUT;
                }
                else if (B >= 4)
                {
                    ret = TurnEndLog.WALK;
                };
                
                return ret;
            }
            public int getRBI()
            {
                return current_H.Count;
            }
            public TurnEndLog HitCaseLog()
            {
                TurnEndLog ret = TurnEndLog.DEFAULT;
                if (current_O.Count == 0)
                {
                    if (current_1B == Batter) ret = TurnEndLog.SINGLE_HIT;
                    else if (current_2B == Batter) ret = TurnEndLog.DOUBLE_HIT;
                    else if (current_3B == Batter) ret = TurnEndLog.TRIPLE_HIT;
                }
                else if (current_O.Count == 1) // 아웃 한사람 1명
                {
                    if (defence.Count == 1) // 수비 관여한 사람 1명
                    {
                        if (current_H.Count > 0)// 홈인 한 사람 1명 이상
                        {
                            if (isBatterout) //타자가 아웃되었을 때
                            {
                                ret = TurnEndLog.SACRIFICE_FLY;
                            }
                            else
                            {
                                ret = TurnEndLog.GROUNDOUT;
                            }
                        }
                        else
                        {
                            ret = TurnEndLog.FLYOUT;
                        }
                    }
                    else if (defence.Count > 1) // 수비 관여한 사람 2명 이상
                    {
                        if (current_H.Count > 0)//홈인 한 사람 한명 이상
                        {
                            if (isBatterout) //타자가 아웃되었을 때
                            {
                                ret = TurnEndLog.SACRIFICE_BUNT;
                            }
                            else
                            {
                                ret = TurnEndLog.GROUNDOUT;
                            }
                        }
                        else
                        {
                            ret = TurnEndLog.GROUNDOUT;
                        }
                    }
                }
                else if (current_O.Count == 2) //아웃한 사람 2명
                {
                    ret = TurnEndLog.DOUBLE_PLAY;
                }
                else if (current_O.Count == 3) //아웃한 사람 3명
                {
                    ret = TurnEndLog.TRIPLE_PLAY;
                }

                last_1B = current_1B;
                last_2B = current_2B;
                last_3B = current_3B;
                return ret;
            }
            public void RunorOut()
            {
                int additionalPoint = 0;
                foreach (var player in current_H)
                {
                    additionalPoint++;
                }
                foreach (var player in current_O)
                {
                    if (player == Batter) isBatterout = true;
                    O++;
                }
                current_H.Clear();
                current_O.Clear();
            }

            int advancedCountWithoutHomein()
            {

                return 0;
            }
        }

    }

    //class Throwing
    //{
    //    float velocity;
    //    string pitch;
    //    int location;
    //}
    
    enum Position
    {
        DH,//지명타자
        SP,//투수
        C,//포수
        B1,//1루수
        B2,//2루수
        B3,//3루수
        SS,//유격수
        LF,//좌익수
        CF,//중견수
        RF//우익수
    }
    enum PitchClass
    {
        FASTBALL,
        CURVEBALL,
        SLIDER,
        FORKBALL,
        KNUCKLEBALL,
        SCREWBALL,
        PALMBALL,
        CHANGEUP
    }
    enum PitchCase
    {
        HIT,
        BUNT,
        STRIKE,
        SWING,
        BALL,
        FOUL,
        HOMERUN,//홈런
        HIT_BY_PITCH,//데드볼
    }
    enum AccidentCase
    {
        STEAL,//도루
        PICKOFF,//견제사
    }
    enum TurnEndLog
    {
        DEFAULT,
        //HIT
        SINGLE_HIT,//1루타
        DOUBLE_HIT,//2루타
        TRIPLE_HIT,//3루타
        HOMERUN,//홈런

        //BASE LOADED WALK
        WALK,//볼넷
        INTENTIONAL_WALK,//고의4구
        HIT_BY_PITCH,//데드볼

        BALKS,//보크

        //JUST A OUT
        STRIKEOUT,//삼진아웃
        GROUNDOUT,//땅볼
        FLYOUT,//뜬공
        TAGOUT,//태그아웃

        //OUTS
        DOUBLE_PLAY,//병살
        TRIPLE_PLAY,//삼중살

        //SACRIFICE
        SACRIFICE_HIT,//희생타
        SACRIFICE_FLY,//희생플라이
        SACRIFICE_BUNT,//희생번트

        //ETC
        NOT_OUT,//낫아웃
        WILD_PITCH,//폭투

    }
}
