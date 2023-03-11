# Refresher Projects

### Overview of Goals & Initial Lesson Plan





1. First ~2 to 4 hours
    * group walkthrough of parts of the Github.com website
    * Walk through repo creation, cloning, forking, pushing to, pulling from & deletion
    * Overview of rudimentary repository management, with examples
    * Introduction to simple markdown writing and styling
    * Following [this guide](), Fork this repository, which will copy the repo to your github account, maintaining a link
    * Self-study (Lab?) time in 20-45 minute blocks to create repositories and try out settings & observe the effects.  
      * Once satisfied or if a repository exhibits problems after a change feel free to delete the repository & create another.
    
    
1. Next roughly 2 to 3 weeks will be shared time between vsCode and Github.com
    * Open vsCode and install these [Required Extensions](#vscode-extensions-list)
      * Optionally you may also install the QoL extensions - I have found them to be very useful.
    * Add or Update these [User Settings](#vscode-user-settings)

     after which we will be utilizing both vsCode and github.com evenly learning the .git CLI and growing our cheat sheet and reference docs, as well as reviewing pull requests.  It will take some time to feel confident with the CLI however after a week or two 
1. Once we begin Unit Tests we will move to ~50% in Visual Studio, ~35% vsCode (for the integrated bash terminal as well as markdown files) and the remaining ~5% on github.com.  Going over familiar territory while increasing knowledge in unit testing should serve to ease you back in gently.

<details>
  <summary>Markdown & Documentation</summary><br />  

  Initially we will be using the github.com web-editor and once some level of comfort has been attained we will primarily be using vsCode for our markdown editor.  I would encourage trying both Visual Studio and vsCode as your markdown editor.
  
  * How to use markdown to write documentation for your own code
  * Useful extensions and plugins for vsCode and/or Visual Studio.
  * Embedding both local & remotely sourced images/assets into your markdown
  * Writing your own examples, walkthroughs & tutorials to refer to in the future.
  * Creating links to sub-sections in the current doc as well as to external Markdown docs, files and pages.
  * Authoring your own references materials such cheat-sheets & links to public repositories & freely available docs, tutorials and tools.

  <sup>_I am confident that Markdown will only require a few hours to at most 2 days to attain a comfort level with using as it's simply an reduced form of HTML.  Also, within the first hour or two we will have begun to look at the Github.com website and the useful features and services available to us while documenting our findings.  Which of course we will be creating and curating within our repository using markdown.  _In fact_ in as little as 30 minutes you may already have the beginnings of your own personal reference library._</sup>
</details>

#### _*** From this point on everything done will be required to have some reasonable level of documentation included in the pull request - as well as the pull request itself occasionally utilizing markdown. ***_

<details>
  <summary>2. Significant effort on all things .git & github.com</summary>

  Introduction to the resources provided at [github.com](https://github.com/)

  Repository Deep-Dive
  * Repository creation, configuration, management, deletion, cloning<sup>(yours & others)</sup> & forking<sup>(others only)</sup>
  * repository types
  * Creating, editing & deleting files/folders via the web GUI
  * draft pull requests
  * reviewing & submitting for review Pull requests
  * repository & account level features such as `Actions`, `Issue Templates`, `Projects`, `Packages`, `Wikis`
  * github account types & the more significant benefits of each tier over the previous account tier

  Additional features & services available elsewhere on [Github.com](https://github.com/) such as
  * [Github Pages](https://pages.github.com/) - 
  * [Github's codespaces](https://github.com/codespaces) - A tiered-subscription web-based IDE service powered by vsCode & hosted by Github - or as they put it: 
    > A codespace is a development environment that's hosted in the cloud.`

  Utilizing the .git cli to manage your repositories.
  * branching & merging strategies
  * branch types
  * workflows, both individual and team.  Potentially also touching on Organization/Enterprise workflows
    * naming conventions for branches, commit messags & ways and means to encourage and/or enforce adherance
    * creation and deletion (local & remote)
  * merge, rebase & cherry-pick, the similarities and differences, _when, why & how_ to use each & when **_not_** to.
  * amending commits
  * merge-conflict resolution (and if we're unlucky, diagnosing and resolving merge-conflicts that lead to 'lost' or overwritten code)  
</details>

<details>
  <summary>3. Unit Tests & Test-Driven-Development (TDD) with MSTest</summary>

  * Test Types (most common being unit, integration, behavioural)
  * The Red-Green-Refactor-Repeat approach
  * Code Coverage
  * Assertions
  * Ideal use-cases and limitations of Mocks vs Fixtures
  * What to test, what to mock and what/when _NOT_ to test
</details>

---
#### vsCode Extensions List
Required Extensions
  - [GitHub Markdown Preview](https://marketplace.visualstudio.com/items?itemName=bierner.github-markdown-preview)


Recommended QoL Extensions
  - []()
[]()
[]()
[]()
[]()

#### vsCode User Settings
* 

[^1]: _with a few notable exceptions_