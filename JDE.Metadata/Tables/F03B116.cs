using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B116 - .
/// </summary>
public class F03B116 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RKCO.
        /// </summary>
        public const string RKCO = "RKCO";

        /// <summary>
        /// RKCRCD.
        /// </summary>
        public const string RKCRCD = "RKCRCD";

        /// <summary>
        /// RKDCT.
        /// </summary>
        public const string RKDCT = "RKDCT";

        /// <summary>
        /// RKDOC.
        /// </summary>
        public const string RKDOC = "RKDOC";

        /// <summary>
        /// RKKCO.
        /// </summary>
        public const string RKKCO = "RKKCO";

        /// <summary>
        /// RKSFX.
        /// </summary>
        public const string RKSFX = "RKSFX";

        /// <summary>
        /// RKDGJ.
        /// </summary>
        public const string RKDGJ = "RKDGJ";

        /// <summary>
        /// RKAAR.
        /// </summary>
        public const string RKAAR = "RKAAR";

        /// <summary>
        /// RKAARE.
        /// </summary>
        public const string RKAARE = "RKAARE";

        /// <summary>
        /// RKAARN.
        /// </summary>
        public const string RKAARN = "RKAARN";

        /// <summary>
        /// RKRSTU.
        /// </summary>
        public const string RKRSTU = "RKRSTU";

        /// <summary>
        /// RKAARI.
        /// </summary>
        public const string RKAARI = "RKAARI";

        /// <summary>
        /// RKRRC.
        /// </summary>
        public const string RKRRC = "RKRRC";

        /// <summary>
        /// RKFAAR.
        /// </summary>
        public const string RKFAAR = "RKFAAR";

        /// <summary>
        /// RKFAARE.
        /// </summary>
        public const string RKFAARE = "RKFAARE";

        /// <summary>
        /// RKFAARN.
        /// </summary>
        public const string RKFAARN = "RKFAARN";

        /// <summary>
        /// RKFAARI.
        /// </summary>
        public const string RKFAARI = "RKFAARI";

        /// <summary>
        /// RKDRR.
        /// </summary>
        public const string RKDRR = "RKDRR";

        /// <summary>
        /// RKUPMJ.
        /// </summary>
        public const string RKUPMJ = "RKUPMJ";

        /// <summary>
        /// RKUPMT.
        /// </summary>
        public const string RKUPMT = "RKUPMT";

        /// <summary>
        /// RKUSER.
        /// </summary>
        public const string RKUSER = "RKUSER";

        /// <summary>
        /// RKPID.
        /// </summary>
        public const string RKPID = "RKPID";

        /// <summary>
        /// RKJOBN.
        /// </summary>
        public const string RKJOBN = "RKJOBN";

        /// <summary>
        /// RKDJ6.
        /// </summary>
        public const string RKDJ6 = "RKDJ6";

        /// <summary>
        /// RKEPDA.
        /// </summary>
        public const string RKEPDA = "RKEPDA";

        /// <summary>
        /// RKCH6.
        /// </summary>
        public const string RKCH6 = "RKCH6";

        /// <summary>
        /// RKEDRR.
        /// </summary>
        public const string RKEDRR = "RKEDRR";
    }

    /// <inheritdoc />
    public override string TableName => "F03B116";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RKCO", "RKCO", JdeDataType.String, 10),
        new JdeField("RKCRCD", "RKCRCD", JdeDataType.String, 6),
        new JdeField("RKDCT", "RKDCT", JdeDataType.String, 4, true, true),
        new JdeField("RKDOC", "RKDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RKKCO", "RKKCO", JdeDataType.String, 10, true, true),
        new JdeField("RKSFX", "RKSFX", JdeDataType.String, 6, true, true),
        new JdeField("RKDGJ", "RKDGJ", JdeDataType.Numeric),
        new JdeField("RKAAR", "RKAAR", JdeDataType.Numeric),
        new JdeField("RKAARE", "RKAARE", JdeDataType.Numeric),
        new JdeField("RKAARN", "RKAARN", JdeDataType.Numeric),
        new JdeField("RKRSTU", "RKRSTU", JdeDataType.String, 2),
        new JdeField("RKAARI", "RKAARI", JdeDataType.Numeric),
        new JdeField("RKRRC", "RKRRC", JdeDataType.String, 2),
        new JdeField("RKFAAR", "RKFAAR", JdeDataType.Numeric),
        new JdeField("RKFAARE", "RKFAARE", JdeDataType.Numeric),
        new JdeField("RKFAARN", "RKFAARN", JdeDataType.Numeric),
        new JdeField("RKFAARI", "RKFAARI", JdeDataType.Numeric),
        new JdeField("RKDRR", "RKDRR", JdeDataType.Numeric),
        new JdeField("RKUPMJ", "RKUPMJ", JdeDataType.Numeric),
        new JdeField("RKUPMT", "RKUPMT", JdeDataType.Numeric),
        new JdeField("RKUSER", "RKUSER", JdeDataType.String, 20),
        new JdeField("RKPID", "RKPID", JdeDataType.String, 20),
        new JdeField("RKJOBN", "RKJOBN", JdeDataType.String, 20),
        new JdeField("RKDJ6", "RKDJ6", JdeDataType.Numeric),
        new JdeField("RKEPDA", "RKEPDA", JdeDataType.Numeric),
        new JdeField("RKCH6", "RKCH6", JdeDataType.String, 2),
        new JdeField("RKEDRR", "RKEDRR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B116_0", "Primary Key on RKDCT, RKDOC, RKKCO, RKSFX", new[] { "RKDCT", "RKDOC", "RKKCO", "RKSFX" }, isUnique: true, isPrimaryKey: true)
    };
}
