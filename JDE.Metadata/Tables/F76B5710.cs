using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B5710 - .
/// </summary>
public class F76B5710 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NFB76AKEY.
        /// </summary>
        public const string NFB76AKEY = "NFB76AKEY";

        /// <summary>
        /// NFFLAG.
        /// </summary>
        public const string NFFLAG = "NFFLAG";

        /// <summary>
        /// NFB76PATH.
        /// </summary>
        public const string NFB76PATH = "NFB76PATH";

        /// <summary>
        /// NFNFLF.
        /// </summary>
        public const string NFNFLF = "NFNFLF";

        /// <summary>
        /// NFFILOC.
        /// </summary>
        public const string NFFILOC = "NFFILOC";

        /// <summary>
        /// NFBNNF.
        /// </summary>
        public const string NFBNNF = "NFBNNF";

        /// <summary>
        /// NFBSER.
        /// </summary>
        public const string NFBSER = "NFBSER";

        /// <summary>
        /// NFDCT.
        /// </summary>
        public const string NFDCT = "NFDCT";

        /// <summary>
        /// NFN001.
        /// </summary>
        public const string NFN001 = "NFN001";

        /// <summary>
        /// NFB76LSER.
        /// </summary>
        public const string NFB76LSER = "NFB76LSER";

        /// <summary>
        /// NFB76LNUM.
        /// </summary>
        public const string NFB76LNUM = "NFB76LNUM";

        /// <summary>
        /// NFUPMJ.
        /// </summary>
        public const string NFUPMJ = "NFUPMJ";

        /// <summary>
        /// NFUPMT.
        /// </summary>
        public const string NFUPMT = "NFUPMT";

        /// <summary>
        /// NFJOBN.
        /// </summary>
        public const string NFJOBN = "NFJOBN";

        /// <summary>
        /// NFUSER.
        /// </summary>
        public const string NFUSER = "NFUSER";

        /// <summary>
        /// NFPID.
        /// </summary>
        public const string NFPID = "NFPID";

        /// <summary>
        /// NFB76TNF.
        /// </summary>
        public const string NFB76TNF = "NFB76TNF";

        /// <summary>
        /// NFFCO.
        /// </summary>
        public const string NFFCO = "NFFCO";
    }

    /// <inheritdoc />
    public override string TableName => "F76B5710";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NFB76AKEY", "NFB76AKEY", JdeDataType.String, 88, true, true),
        new JdeField("NFFLAG", "NFFLAG", JdeDataType.String, 2, true, true),
        new JdeField("NFB76PATH", "NFB76PATH", JdeDataType.String, 510),
        new JdeField("NFNFLF", "NFNFLF", JdeDataType.String, 500),
        new JdeField("NFFILOC", "NFFILOC", JdeDataType.String, 500),
        new JdeField("NFBNNF", "NFBNNF", JdeDataType.Numeric),
        new JdeField("NFBSER", "NFBSER", JdeDataType.String, 4),
        new JdeField("NFDCT", "NFDCT", JdeDataType.String, 4),
        new JdeField("NFN001", "NFN001", JdeDataType.Numeric),
        new JdeField("NFB76LSER", "NFB76LSER", JdeDataType.String, 20),
        new JdeField("NFB76LNUM", "NFB76LNUM", JdeDataType.Numeric),
        new JdeField("NFUPMJ", "NFUPMJ", JdeDataType.Numeric),
        new JdeField("NFUPMT", "NFUPMT", JdeDataType.Numeric),
        new JdeField("NFJOBN", "NFJOBN", JdeDataType.String, 20),
        new JdeField("NFUSER", "NFUSER", JdeDataType.String, 20),
        new JdeField("NFPID", "NFPID", JdeDataType.String, 20),
        new JdeField("NFB76TNF", "NFB76TNF", JdeDataType.String, 20),
        new JdeField("NFFCO", "NFFCO", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B5710_0", "Primary Key on NFB76AKEY, NFFLAG", new[] { "NFB76AKEY", "NFFLAG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B5710_2", "Index on NFBNNF, NFBSER, NFDCT, NFN001", new[] { "NFBNNF", "NFBSER", "NFDCT", "NFN001" }),
        new JdeIndex("F76B5710_3", "Index on NFB76LSER, NFB76LNUM, NFB76TNF, NFFCO", new[] { "NFB76LSER", "NFB76LNUM", "NFB76TNF", "NFFCO" })
    };
}
