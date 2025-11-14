using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F980044 - .
/// </summary>
public class F980044 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MSMMTMPI.
        /// </summary>
        public const string MSMMTMPI = "MSMMTMPI";

        /// <summary>
        /// MSMMTPNAME.
        /// </summary>
        public const string MSMMTPNAME = "MSMMTPNAME";

        /// <summary>
        /// MSEDSNM.
        /// </summary>
        public const string MSEDSNM = "MSEDSNM";

        /// <summary>
        /// MSACTTYPE.
        /// </summary>
        public const string MSACTTYPE = "MSACTTYPE";

        /// <summary>
        /// MSCDAA.
        /// </summary>
        public const string MSCDAA = "MSCDAA";

        /// <summary>
        /// MSCDBB.
        /// </summary>
        public const string MSCDBB = "MSCDBB";

        /// <summary>
        /// MSFNDFUF1.
        /// </summary>
        public const string MSFNDFUF1 = "MSFNDFUF1";

        /// <summary>
        /// MSFNDFUF2.
        /// </summary>
        public const string MSFNDFUF2 = "MSFNDFUF2";

        /// <summary>
        /// MSSEQUENCEN.
        /// </summary>
        public const string MSSEQUENCEN = "MSSEQUENCEN";

        /// <summary>
        /// MSMMFEXT.
        /// </summary>
        public const string MSMMFEXT = "MSMMFEXT";

        /// <summary>
        /// MSTXFT.
        /// </summary>
        public const string MSTXFT = "MSTXFT";

        /// <summary>
        /// MSPID.
        /// </summary>
        public const string MSPID = "MSPID";

        /// <summary>
        /// MSUSER.
        /// </summary>
        public const string MSUSER = "MSUSER";

        /// <summary>
        /// MSJOBN.
        /// </summary>
        public const string MSJOBN = "MSJOBN";

        /// <summary>
        /// MSUPMJ.
        /// </summary>
        public const string MSUPMJ = "MSUPMJ";

        /// <summary>
        /// MSUPMT.
        /// </summary>
        public const string MSUPMT = "MSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F980044";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MSMMTMPI", "MSMMTMPI", JdeDataType.String, 20, true, true),
        new JdeField("MSMMTPNAME", "MSMMTPNAME", JdeDataType.String, 60, true, true),
        new JdeField("MSEDSNM", "MSEDSNM", JdeDataType.String, 22),
        new JdeField("MSACTTYPE", "MSACTTYPE", JdeDataType.String, 4),
        new JdeField("MSCDAA", "MSCDAA", JdeDataType.String, 4),
        new JdeField("MSCDBB", "MSCDBB", JdeDataType.String, 4),
        new JdeField("MSFNDFUF1", "MSFNDFUF1", JdeDataType.String, 60),
        new JdeField("MSFNDFUF2", "MSFNDFUF2", JdeDataType.String, 60),
        new JdeField("MSSEQUENCEN", "MSSEQUENCEN", JdeDataType.Numeric, null, true, true),
        new JdeField("MSMMFEXT", "MSMMFEXT", JdeDataType.String, 6),
        new JdeField("MSTXFT", "MSTXFT", JdeDataType.String),
        new JdeField("MSPID", "MSPID", JdeDataType.String, 20),
        new JdeField("MSUSER", "MSUSER", JdeDataType.String, 20),
        new JdeField("MSJOBN", "MSJOBN", JdeDataType.String, 20),
        new JdeField("MSUPMJ", "MSUPMJ", JdeDataType.Numeric),
        new JdeField("MSUPMT", "MSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F980044_0", "Primary Key on MSMMTMPI, MSSEQUENCEN, MSMMTPNAME", new[] { "MSMMTMPI", "MSSEQUENCEN", "MSMMTPNAME" }, isUnique: true, isPrimaryKey: true)
    };
}
