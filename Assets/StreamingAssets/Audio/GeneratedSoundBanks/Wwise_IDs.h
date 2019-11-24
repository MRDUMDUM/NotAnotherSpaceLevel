/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID PLAY_DANGERTOXICGAS = 2100760483U;
        static const AkUniqueID PLAY_DEATH = 1172822028U;
        static const AkUniqueID PLAY_DOORCLOSE = 2721379730U;
        static const AkUniqueID PLAY_DOOROPEN = 3197300806U;
        static const AkUniqueID PLAY_ESCAPEVOICE = 488168703U;
        static const AkUniqueID PLAY_GOGGLES_ACTIVATE = 2295817318U;
        static const AkUniqueID PLAY_GOGGLES_DEACTIVATE = 2855167047U;
        static const AkUniqueID PLAY_GRAVITYACT = 5356008U;
        static const AkUniqueID PLAY_GRAVITYDIS = 4265929456U;
        static const AkUniqueID PLAY_HACK_DENIED = 2890400009U;
        static const AkUniqueID PLAY_HACK_SUCCES = 2267716414U;
        static const AkUniqueID PLAY_JUMP = 3689126666U;
        static const AkUniqueID PLAY_METEORHIT = 867002421U;
        static const AkUniqueID PLAY_METEORVOICE = 561502880U;
        static const AkUniqueID PLAY_MUSIC = 2932040671U;
        static const AkUniqueID PLAY_PROCEEDVOICE = 2868217562U;
        static const AkUniqueID PLAY_SKILL_LEVELDOWN = 1096525642U;
        static const AkUniqueID PLAY_SKILL_LEVELUP = 4192500681U;
        static const AkUniqueID PLAY_SKILL_MANAGEOPEN = 456935401U;
        static const AkUniqueID PLAY_STARTGAME = 1444205428U;
        static const AkUniqueID PLAY_STUNNED = 1426838595U;
        static const AkUniqueID PLAY_UI = 2044747472U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace GAMEPHASE
        {
            static const AkUniqueID GROUP = 768929368U;

            namespace STATE
            {
                static const AkUniqueID MAIN = 3161908922U;
                static const AkUniqueID MENU_TUTORIAL = 1018478861U;
                static const AkUniqueID VICTORY = 2716678721U;
            } // namespace STATE
        } // namespace GAMEPHASE

        namespace MENUSTATE
        {
            static const AkUniqueID GROUP = 1548586727U;

            namespace STATE
            {
                static const AkUniqueID INGAME = 984691642U;
                static const AkUniqueID INMENU = 3374585465U;
            } // namespace STATE
        } // namespace MENUSTATE

        namespace PLAYERSTATE
        {
            static const AkUniqueID GROUP = 3285234865U;

            namespace STATE
            {
                static const AkUniqueID ALIVE = 655265632U;
                static const AkUniqueID DEAD = 2044049779U;
            } // namespace STATE
        } // namespace PLAYERSTATE

    } // namespace STATES

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID SOUNDBANK = 1661994096U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID MUSIC = 3991942870U;
        static const AkUniqueID SFX = 393239870U;
        static const AkUniqueID VOICE = 3170124113U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
