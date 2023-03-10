# Refresher Projects

### Overview of Goals & Initial Lesson Plan

We will begin by spending the first 2 to 3 weeks in on Github.com, in Visual Studio and working with C#, going over familiar territory to ease you back in. [^1] As such, what follows is a the initial draft for my proposed _lesson plan_

<details>
  <summary>Documentation & Markdown</summary>

  * How to write documentation for your own code
  * Writing examples, walkthroughs & tutorials
  * Authoring your own quick-references (cheat-sheets & documentation/reference materials freely available)
  * Embedding both local and remotely sourced images as well as some select other assets into your markdown
  * Creating links to other Markdown docs & hyperlinks - locally & remote

  I am confident that Markdown will only require a few hours to at most 2 days to attain a comfort level with using as it's simply an reduced form of HTML.  Also, within the first hour or two we will have begun to look at the Github.com website and the useful features and services available to us while documenting our findings - in, of course, markdown files within our repository.  _In fact_ as soon as 30 minutes in you will already have taken the first steps in creating and curating your own personal reference library.

</details>

##### _Everything done will be required to have some reasonable level of documentation included in the pull request - as well as the pull request itself occasionally utilizing markdown._

<details>
  <summary>Significant effort on all things .git & github.com</summary>

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
  <summary>Unit Tests & Test-Driven-Development (TDD) with MSTest</summary>

  * Test Types (most common being unit, integration, behavioural)
  * The Red-Green-Refactor-Repeat approach
  * Code Coverage
  * Assertions
  * Ideal use-cases and limitations of Mocks vs Fixtures
  * What to test, what to mock and what/when _NOT_ to test


</details>

[^1]: _with a few notable exceptions_