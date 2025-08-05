# PoC: AI Actions

An example for adding an AI review to GitHub Actions. 
**[This action](./.github/workflows/ai-action.yml)** will compare a pull 
request to its target branch. There are comments in the file to explain
what is happening.

The result is the AI commenting on the **[Example Pull Request](https://github.com/SteffiSchulzITTitans/poc-ai-actions/pull/1#issue-comment-box)**. 
The description of the PR shows what kind of comment is expected. If you want to 
test this workflow for yourself, create your own PR.

**Note:** This action does not work if the repository is an organization. I do not know why, 
yet, but I assume that organisations have a different set of restrictions / permissions
for accessing CoPilot and AI.

If you want to upload one of the files for debugging purposes,
add these:

#### Prompt File

_This file contains the entire prompt with the Git diff that is send to the AI._

```yaml
      - name: 🎁 Upload prompt file
        uses: actions/upload-artifact@v4
        with:
          name: ${{ env.PROMPT_FILE }}
          path: ${{ env.PROMPT_FILE }}
```

#### Comment File

_This file contains the entire answer of the AI._

```yaml
      - name: 🎁 Upload comment file
        uses: actions/upload-artifact@v4
        with:
          name: comment.txt
          path: ${{ steps.inference.outputs.response-file }}
```