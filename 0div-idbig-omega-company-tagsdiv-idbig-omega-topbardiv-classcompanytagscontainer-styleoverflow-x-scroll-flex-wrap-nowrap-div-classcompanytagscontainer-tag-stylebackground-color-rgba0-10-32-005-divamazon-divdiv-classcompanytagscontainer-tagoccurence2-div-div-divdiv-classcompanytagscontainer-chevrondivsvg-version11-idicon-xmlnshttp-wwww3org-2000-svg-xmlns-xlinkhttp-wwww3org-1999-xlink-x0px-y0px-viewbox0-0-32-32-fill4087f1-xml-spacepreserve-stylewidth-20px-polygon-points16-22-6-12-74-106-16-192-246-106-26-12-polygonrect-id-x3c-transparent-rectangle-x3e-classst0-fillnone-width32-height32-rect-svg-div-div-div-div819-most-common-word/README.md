<h2><a href="https://leetcode.com/problems/most-common-word/"><div id="big-omega-company-tags"><div id="big-omega-topbar"><div class="companyTagsContainer" style="overflow-x: scroll; flex-wrap: nowrap;"><div class="companyTagsContainer--tag" style="background-color: rgba(0, 10, 32, 0.05);"><div>Amazon</div><div class="companyTagsContainer--tagOccurence">2</div></div></div><div class="companyTagsContainer--chevron"><div><svg version="1.1" id="icon" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" viewBox="0 0 32 32" fill="#4087F1" xml:space="preserve" style="width: 20px;"><polygon points="16,22 6,12 7.4,10.6 16,19.2 24.6,10.6 26,12 "></polygon><rect id="_x3C_Transparent_Rectangle_x3E_" class="st0" fill="none" width="32" height="32"></rect></svg></div></div></div></div>819. Most Common Word</a></h2><h3>Easy</h3><hr><div><p>Given a string <code>paragraph</code> and a string array of the banned words <code>banned</code>, return <em>the most frequent word that is not banned</em>. It is <strong>guaranteed</strong> there is <strong>at least one word</strong> that is not banned, and that the answer is <strong>unique</strong>.</p>

<p>The words in <code>paragraph</code> are <strong>case-insensitive</strong> and the answer should be returned in <strong>lowercase</strong>.</p>

<p>&nbsp;</p>
<p><strong class="example">Example 1:</strong></p>

<pre><strong>Input:</strong> paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.", banned = ["hit"]
<strong>Output:</strong> "ball"
<strong>Explanation:</strong> 
"hit" occurs 3 times, but it is a banned word.
"ball" occurs twice (and no other word does), so it is the most frequent non-banned word in the paragraph. 
Note that words in the paragraph are not case sensitive,
that punctuation is ignored (even if adjacent to words, such as "ball,"), 
and that "hit" isn't the answer even though it occurs more because it is banned.
</pre>

<p><strong class="example">Example 2:</strong></p>

<pre><strong>Input:</strong> paragraph = "a.", banned = []
<strong>Output:</strong> "a"
</pre>

<p>&nbsp;</p>
<p><strong>Constraints:</strong></p>

<ul>
	<li><code>1 &lt;= paragraph.length &lt;= 1000</code></li>
	<li>paragraph consists of English letters, space <code>' '</code>, or one of the symbols: <code>"!?',;."</code>.</li>
	<li><code>0 &lt;= banned.length &lt;= 100</code></li>
	<li><code>1 &lt;= banned[i].length &lt;= 10</code></li>
	<li><code>banned[i]</code> consists of only lowercase English letters.</li>
</ul>
</div>