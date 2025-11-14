using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F37015 - .
/// </summary>
public class F37015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTRSCONVID.
        /// </summary>
        public const string CTRSCONVID = "CTRSCONVID";

        /// <summary>
        /// CTLNID.
        /// </summary>
        public const string CTLNID = "CTLNID";

        /// <summary>
        /// CTDSC1.
        /// </summary>
        public const string CTDSC1 = "CTDSC1";

        /// <summary>
        /// CTRSCNVTYP.
        /// </summary>
        public const string CTRSCNVTYP = "CTRSCNVTYP";

        /// <summary>
        /// CTEFTJ.
        /// </summary>
        public const string CTEFTJ = "CTEFTJ";

        /// <summary>
        /// CTEXDJ.
        /// </summary>
        public const string CTEXDJ = "CTEXDJ";

        /// <summary>
        /// CTFRMRSVAL.
        /// </summary>
        public const string CTFRMRSVAL = "CTFRMRSVAL";

        /// <summary>
        /// CTTORSVAL.
        /// </summary>
        public const string CTTORSVAL = "CTTORSVAL";

        /// <summary>
        /// CTCNVRSVAL.
        /// </summary>
        public const string CTCNVRSVAL = "CTCNVRSVAL";

        /// <summary>
        /// CTURCD.
        /// </summary>
        public const string CTURCD = "CTURCD";

        /// <summary>
        /// CTURAT.
        /// </summary>
        public const string CTURAT = "CTURAT";

        /// <summary>
        /// CTURRF.
        /// </summary>
        public const string CTURRF = "CTURRF";

        /// <summary>
        /// CTURAB.
        /// </summary>
        public const string CTURAB = "CTURAB";

        /// <summary>
        /// CTURDT.
        /// </summary>
        public const string CTURDT = "CTURDT";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTUPMJ.
        /// </summary>
        public const string CTUPMJ = "CTUPMJ";

        /// <summary>
        /// CTTDAY.
        /// </summary>
        public const string CTTDAY = "CTTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F37015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTRSCONVID", "CTRSCONVID", JdeDataType.String, 60, true, true),
        new JdeField("CTLNID", "CTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CTDSC1", "CTDSC1", JdeDataType.String, 60),
        new JdeField("CTRSCNVTYP", "CTRSCNVTYP", JdeDataType.String, 2),
        new JdeField("CTEFTJ", "CTEFTJ", JdeDataType.Numeric),
        new JdeField("CTEXDJ", "CTEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CTFRMRSVAL", "CTFRMRSVAL", JdeDataType.String, 30),
        new JdeField("CTTORSVAL", "CTTORSVAL", JdeDataType.String, 30),
        new JdeField("CTCNVRSVAL", "CTCNVRSVAL", JdeDataType.String, 30),
        new JdeField("CTURCD", "CTURCD", JdeDataType.String, 4),
        new JdeField("CTURAT", "CTURAT", JdeDataType.Numeric),
        new JdeField("CTURRF", "CTURRF", JdeDataType.String, 30),
        new JdeField("CTURAB", "CTURAB", JdeDataType.Numeric),
        new JdeField("CTURDT", "CTURDT", JdeDataType.Numeric),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTTDAY", "CTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F37015_0", "Primary Key on CTRSCONVID, CTEXDJ, CTLNID", new[] { "CTRSCONVID", "CTEXDJ", "CTLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F37015_3", "Unique Index on CTRSCONVID, SYS_NC00019$, CTFRMRSVAL", new[] { "CTRSCONVID", "SYS_NC00019$", "CTFRMRSVAL" }, isUnique: true)
    };
}
