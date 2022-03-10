using System;
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
        public BaseState Base = new BaseState();
        public string Pitcher = "None";
        public string Batter = "None";
        public TeamInformation redTeam = new TeamInformation("Socks");
        public TeamInformation blueTeam = new TeamInformation("Shoes");
        public int inning = 0;
        public int S = 0;
        public int B = 0;
        public int O = 0;

        public void RunorOut()
        {
            int additionalPoint = 0;
            while(Base.current_H.Count>0) {
                Base.current_H.Dequeue();
                additionalPoint++;
            }
            while(Base.current_O.Count>0)
            {
                Base.current_O.Dequeue();
                O++;
            }
            
        }
    }
    class TeamInformation
    {
        public string Name = "None";
        public int Score = 0;
        public TeamInformation(string name)
        {
            Name = name;
        }
    }
    class Throwing
    {
        float velocity;
        string pitch;
        int location;
    }
    class BaseState
    {
        string last_1B = "None";
        string last_2B = "None";
        string last_3B = "None";
        public string current_1B = "None";
        public string current_2B = "None";
        public string current_3B = "None";
        public List<string> current_H = new List<string>();//홈인 한 사람
        public List<string> current_O = new List<string>();//아웃 된 사람
        
        public Queue<TurnEndLog> log(List<Position> defence, string batter, int outcount)
        {
            Queue<TurnEndLog> ret = new Queue<TurnEndLog>();

            if (current_O.Count == 1) // 아웃 한사람 1명
            {
                if (defence.Count == 1) // 수비 관여한 사람 1명
                {
                    if (current_H.Count > 0)// 홈인 한 사람 1명 이상
                    {
                        ret.Enqueue(TurnEndLog.SACRIFICE_FLY);
                    }
                    ret.Enqueue(TurnEndLog.FLYOUT);
                }
                if(defence.Count > 1) // 수비 관여한 사람 2명 이상
                {

                }
            }
            if (current_O.Count == 2) //아웃한 사람 2명
            {
                if (defence.Count == 1)
                {
                    ret.Enqueue(TurnEndLog.DOUBLE_PLAY);
                }
            }
            if (current_O.Count == 3) //아웃한 사람 3명
            {
                if (outcount == 0) ret.Enqueue(TurnEndLog.TRIPLE_PLAY);
                else if (outcount == 1) ret.Enqueue(TurnEndLog.DOUBLE_PLAY);

            }

            last_1B = current_1B;
            last_2B = current_2B;
            last_3B = current_3B;


            return ret;
        }
        int advancedCountWithoutHomein()
        {

            return 0;
        }
    }
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
    enum PitchLog
    {
        HIT,
        BUNT,
        STRIKE,
        SWING,
        BALL,
        FOUL,
    }
    enum AccidentLog
    {
        STEAL,//도루
        PICKOFF,//견제사
    }
    enum TurnEndLog
    {
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
