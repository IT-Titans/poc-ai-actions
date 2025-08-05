# PoC: AI Actions

An example for adding an AI review to GitHub Actions. 
[This action](./.github/workflows/ai-action.yml) will compare a pull 
request to its target branch. There are comments in the file to explain
what is happening.

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
          name: ${{ env.COMMENT_FILE }}
          path: ${{ env.COMMENT_FILE }}
```