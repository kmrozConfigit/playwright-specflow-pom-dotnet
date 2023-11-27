Feature: Ace
Ace scenarios

    Scenario: Ace boarding opened after authorization of 'bot_testautomation@configit.com'
        And Breakpoint     
        Given Login as 'bot_testautomation@configit.com' to the Ace application 'https://acedev-aceplatform-dev.configit.cloud/'  
        And Ace boarding page opened
        And Wait 15 seconds 