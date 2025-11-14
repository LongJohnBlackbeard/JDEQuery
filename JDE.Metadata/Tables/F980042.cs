using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F980042 - .
/// </summary>
public class F980042 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STMMTMPI.
        /// </summary>
        public const string STMMTMPI = "STMMTMPI";

        /// <summary>
        /// STMMTPNAME.
        /// </summary>
        public const string STMMTPNAME = "STMMTPNAME";

        /// <summary>
        /// STMMVERS.
        /// </summary>
        public const string STMMVERS = "STMMVERS";

        /// <summary>
        /// STCDAA.
        /// </summary>
        public const string STCDAA = "STCDAA";

        /// <summary>
        /// STCDBB.
        /// </summary>
        public const string STCDBB = "STCDBB";

        /// <summary>
        /// STCDCC.
        /// </summary>
        public const string STCDCC = "STCDCC";

        /// <summary>
        /// STFNDFUF1.
        /// </summary>
        public const string STFNDFUF1 = "STFNDFUF1";

        /// <summary>
        /// STFNDFUF2.
        /// </summary>
        public const string STFNDFUF2 = "STFNDFUF2";

        /// <summary>
        /// STSEQUENCEN.
        /// </summary>
        public const string STSEQUENCEN = "STSEQUENCEN";

        /// <summary>
        /// STMMFEXT.
        /// </summary>
        public const string STMMFEXT = "STMMFEXT";

        /// <summary>
        /// STTXFT.
        /// </summary>
        public const string STTXFT = "STTXFT";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F980042";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STMMTMPI", "STMMTMPI", JdeDataType.String, 20, true, true),
        new JdeField("STMMTPNAME", "STMMTPNAME", JdeDataType.String, 60, true, true),
        new JdeField("STMMVERS", "STMMVERS", JdeDataType.String, 60, true, true),
        new JdeField("STCDAA", "STCDAA", JdeDataType.String, 4),
        new JdeField("STCDBB", "STCDBB", JdeDataType.String, 4),
        new JdeField("STCDCC", "STCDCC", JdeDataType.String, 4),
        new JdeField("STFNDFUF1", "STFNDFUF1", JdeDataType.String, 60),
        new JdeField("STFNDFUF2", "STFNDFUF2", JdeDataType.String, 60),
        new JdeField("STSEQUENCEN", "STSEQUENCEN", JdeDataType.Numeric, null, true, true),
        new JdeField("STMMFEXT", "STMMFEXT", JdeDataType.String, 6),
        new JdeField("STTXFT", "STTXFT", JdeDataType.String),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F980042_0", "Primary Key on STMMTMPI, STMMTPNAME, STMMVERS, STSEQUENCEN", new[] { "STMMTMPI", "STMMTPNAME", "STMMVERS", "STSEQUENCEN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F980042_3", "Index on STMMFEXT", new[] { "STMMFEXT" })
    };
}
