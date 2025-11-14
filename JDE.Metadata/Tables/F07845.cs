using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07845 - .
/// </summary>
public class F07845 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FZFNDB.
        /// </summary>
        public const string FZFNDB = "FZFNDB";

        /// <summary>
        /// FZFNDN.
        /// </summary>
        public const string FZFNDN = "FZFNDN";

        /// <summary>
        /// FZANN8.
        /// </summary>
        public const string FZANN8 = "FZANN8";

        /// <summary>
        /// FZFNDL.
        /// </summary>
        public const string FZFNDL = "FZFNDL";

        /// <summary>
        /// FZGS2A.
        /// </summary>
        public const string FZGS2A = "FZGS2A";

        /// <summary>
        /// FZGS2B.
        /// </summary>
        public const string FZGS2B = "FZGS2B";

        /// <summary>
        /// FZA111.
        /// </summary>
        public const string FZA111 = "FZA111";

        /// <summary>
        /// FZA112.
        /// </summary>
        public const string FZA112 = "FZA112";

        /// <summary>
        /// FZGNUM1.
        /// </summary>
        public const string FZGNUM1 = "FZGNUM1";

        /// <summary>
        /// FZGNUM2.
        /// </summary>
        public const string FZGNUM2 = "FZGNUM2";

        /// <summary>
        /// FZUSER.
        /// </summary>
        public const string FZUSER = "FZUSER";

        /// <summary>
        /// FZJOBN.
        /// </summary>
        public const string FZJOBN = "FZJOBN";

        /// <summary>
        /// FZPID.
        /// </summary>
        public const string FZPID = "FZPID";

        /// <summary>
        /// FZUPMJ.
        /// </summary>
        public const string FZUPMJ = "FZUPMJ";

        /// <summary>
        /// FZUPMT.
        /// </summary>
        public const string FZUPMT = "FZUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F07845";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FZFNDB", "FZFNDB", JdeDataType.String, 30, true, true),
        new JdeField("FZFNDN", "FZFNDN", JdeDataType.String, 100),
        new JdeField("FZANN8", "FZANN8", JdeDataType.Numeric),
        new JdeField("FZFNDL", "FZFNDL", JdeDataType.String, 40),
        new JdeField("FZGS2A", "FZGS2A", JdeDataType.String, 40),
        new JdeField("FZGS2B", "FZGS2B", JdeDataType.String, 40),
        new JdeField("FZA111", "FZA111", JdeDataType.String, 2),
        new JdeField("FZA112", "FZA112", JdeDataType.String, 2),
        new JdeField("FZGNUM1", "FZGNUM1", JdeDataType.Numeric),
        new JdeField("FZGNUM2", "FZGNUM2", JdeDataType.Numeric),
        new JdeField("FZUSER", "FZUSER", JdeDataType.String, 20),
        new JdeField("FZJOBN", "FZJOBN", JdeDataType.String, 20),
        new JdeField("FZPID", "FZPID", JdeDataType.String, 20),
        new JdeField("FZUPMJ", "FZUPMJ", JdeDataType.Numeric),
        new JdeField("FZUPMT", "FZUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07845_0", "Primary Key on FZFNDB", new[] { "FZFNDB" }, isUnique: true, isPrimaryKey: true)
    };
}
