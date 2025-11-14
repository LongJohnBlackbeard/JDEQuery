using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76121B - .
/// </summary>
public class F76121B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FZBNNF.
        /// </summary>
        public const string FZBNNF = "FZBNNF";

        /// <summary>
        /// FZBSER.
        /// </summary>
        public const string FZBSER = "FZBSER";

        /// <summary>
        /// FZN001.
        /// </summary>
        public const string FZN001 = "FZN001";

        /// <summary>
        /// FZDCT.
        /// </summary>
        public const string FZDCT = "FZDCT";

        /// <summary>
        /// FZLIN.
        /// </summary>
        public const string FZLIN = "FZLIN";

        /// <summary>
        /// FZSEQ.
        /// </summary>
        public const string FZSEQ = "FZSEQ";

        /// <summary>
        /// FZINMG.
        /// </summary>
        public const string FZINMG = "FZINMG";

        /// <summary>
        /// FZUSER.
        /// </summary>
        public const string FZUSER = "FZUSER";

        /// <summary>
        /// FZPID.
        /// </summary>
        public const string FZPID = "FZPID";

        /// <summary>
        /// FZJOBN.
        /// </summary>
        public const string FZJOBN = "FZJOBN";

        /// <summary>
        /// FZUPMJ.
        /// </summary>
        public const string FZUPMJ = "FZUPMJ";

        /// <summary>
        /// FZTDAY.
        /// </summary>
        public const string FZTDAY = "FZTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76121B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FZBNNF", "FZBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("FZBSER", "FZBSER", JdeDataType.String, 4, true, true),
        new JdeField("FZN001", "FZN001", JdeDataType.Numeric, null, true, true),
        new JdeField("FZDCT", "FZDCT", JdeDataType.String, 4, true, true),
        new JdeField("FZLIN", "FZLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("FZSEQ", "FZSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("FZINMG", "FZINMG", JdeDataType.String, 20),
        new JdeField("FZUSER", "FZUSER", JdeDataType.String, 20),
        new JdeField("FZPID", "FZPID", JdeDataType.String, 20),
        new JdeField("FZJOBN", "FZJOBN", JdeDataType.String, 20),
        new JdeField("FZUPMJ", "FZUPMJ", JdeDataType.Numeric),
        new JdeField("FZTDAY", "FZTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76121B_0", "Primary Key on FZBNNF, FZBSER, FZN001, FZDCT, FZSEQ, FZLIN", new[] { "FZBNNF", "FZBSER", "FZN001", "FZDCT", "FZSEQ", "FZLIN" }, isUnique: true, isPrimaryKey: true)
    };
}
