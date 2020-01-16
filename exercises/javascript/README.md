This project uses `node` version 10, and `nvm` (node version manager) to manage the version of `node`.

1. Make sure `nvm` is installed by following [the nvm installation instructions](https://github.com/nvm-sh/nvm/blob/master/README.md#installing-and-updating).  
    If you previously installed `nvm` using homebrew, run `brew uninstall nvm` first as this mechanism is unsupported<sup>[*](https://github.com/nvm-sh/nvm/issues/856)</sup> and doesn’t let you run `nvm exec`.
1. Make sure you have the correct version of `node` by running `nvm install`.
1. Make sure you have all the required packages by running `npm install` (note the subtle difference between `nvm` in the previous step and `npm` here).

Now you can run the tests (against the right version of node) using `nvm exec npm test`.