using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31K22 - .
/// </summary>
public class FF31K22 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PSFSCID.
        /// </summary>
        public const string PSFSCID = "PSFSCID";

        /// <summary>
        /// PSPMAPID.
        /// </summary>
        public const string PSPMAPID = "PSPMAPID";

        /// <summary>
        /// PSCMITM.
        /// </summary>
        public const string PSCMITM = "PSCMITM";

        /// <summary>
        /// PSBOSTR.
        /// </summary>
        public const string PSBOSTR = "PSBOSTR";

        /// <summary>
        /// PSPCODE.
        /// </summary>
        public const string PSPCODE = "PSPCODE";

        /// <summary>
        /// PSFDCMCU.
        /// </summary>
        public const string PSFDCMCU = "PSFDCMCU";

        /// <summary>
        /// PSDFCLOC.
        /// </summary>
        public const string PSDFCLOC = "PSDFCLOC";

        /// <summary>
        /// PSDFSMCU.
        /// </summary>
        public const string PSDFSMCU = "PSDFSMCU";

        /// <summary>
        /// PSDFSLOC.
        /// </summary>
        public const string PSDFSLOC = "PSDFSLOC";

        /// <summary>
        /// PSSUPN.
        /// </summary>
        public const string PSSUPN = "PSSUPN";

        /// <summary>
        /// PSPSDQTY.
        /// </summary>
        public const string PSPSDQTY = "PSPSDQTY";

        /// <summary>
        /// PSKANUOM.
        /// </summary>
        public const string PSKANUOM = "PSKANUOM";

        /// <summary>
        /// PSKANFAS.
        /// </summary>
        public const string PSKANFAS = "PSKANFAS";

        /// <summary>
        /// PSREPHRS.
        /// </summary>
        public const string PSREPHRS = "PSREPHRS";

        /// <summary>
        /// PSDFREPT.
        /// </summary>
        public const string PSDFREPT = "PSDFREPT";

        /// <summary>
        /// PSLNDSID.
        /// </summary>
        public const string PSLNDSID = "PSLNDSID";

        /// <summary>
        /// PSKANPRL.
        /// </summary>
        public const string PSKANPRL = "PSKANPRL";

        /// <summary>
        /// PSKNOREP.
        /// </summary>
        public const string PSKNOREP = "PSKNOREP";

        /// <summary>
        /// PSKFRIP.
        /// </summary>
        public const string PSKFRIP = "PSKFRIP";

        /// <summary>
        /// PSURCD.
        /// </summary>
        public const string PSURCD = "PSURCD";

        /// <summary>
        /// PSURDT.
        /// </summary>
        public const string PSURDT = "PSURDT";

        /// <summary>
        /// PSURAT.
        /// </summary>
        public const string PSURAT = "PSURAT";

        /// <summary>
        /// PSURAB.
        /// </summary>
        public const string PSURAB = "PSURAB";

        /// <summary>
        /// PSURRF.
        /// </summary>
        public const string PSURRF = "PSURRF";

        /// <summary>
        /// PSTORG.
        /// </summary>
        public const string PSTORG = "PSTORG";

        /// <summary>
        /// PSUSER.
        /// </summary>
        public const string PSUSER = "PSUSER";

        /// <summary>
        /// PSJOBN.
        /// </summary>
        public const string PSJOBN = "PSJOBN";

        /// <summary>
        /// PSPID.
        /// </summary>
        public const string PSPID = "PSPID";

        /// <summary>
        /// PSDFEFDT.
        /// </summary>
        public const string PSDFEFDT = "PSDFEFDT";

        /// <summary>
        /// PSDFLNID.
        /// </summary>
        public const string PSDFLNID = "PSDFLNID";

        /// <summary>
        /// PSKLBMSG.
        /// </summary>
        public const string PSKLBMSG = "PSKLBMSG";

        /// <summary>
        /// PSUUPMJ.
        /// </summary>
        public const string PSUUPMJ = "PSUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF31K22";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PSFSCID", "PSFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("PSPMAPID", "PSPMAPID", JdeDataType.Numeric, null, true, true),
        new JdeField("PSCMITM", "PSCMITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PSBOSTR", "PSBOSTR", JdeDataType.String, 8, true, true),
        new JdeField("PSPCODE", "PSPCODE", JdeDataType.String, 4),
        new JdeField("PSFDCMCU", "PSFDCMCU", JdeDataType.String, 24, true, true),
        new JdeField("PSDFCLOC", "PSDFCLOC", JdeDataType.String, 40, true, true),
        new JdeField("PSDFSMCU", "PSDFSMCU", JdeDataType.String, 24, true, true),
        new JdeField("PSDFSLOC", "PSDFSLOC", JdeDataType.String, 40, true, true),
        new JdeField("PSSUPN", "PSSUPN", JdeDataType.Numeric, null, true, true),
        new JdeField("PSPSDQTY", "PSPSDQTY", JdeDataType.Numeric),
        new JdeField("PSKANUOM", "PSKANUOM", JdeDataType.String, 4),
        new JdeField("PSKANFAS", "PSKANFAS", JdeDataType.Numeric),
        new JdeField("PSREPHRS", "PSREPHRS", JdeDataType.Numeric),
        new JdeField("PSDFREPT", "PSDFREPT", JdeDataType.String, 2),
        new JdeField("PSLNDSID", "PSLNDSID", JdeDataType.Numeric),
        new JdeField("PSKANPRL", "PSKANPRL", JdeDataType.String, 2),
        new JdeField("PSKNOREP", "PSKNOREP", JdeDataType.String, 2),
        new JdeField("PSKFRIP", "PSKFRIP", JdeDataType.String, 2),
        new JdeField("PSURCD", "PSURCD", JdeDataType.String, 4),
        new JdeField("PSURDT", "PSURDT", JdeDataType.Numeric),
        new JdeField("PSURAT", "PSURAT", JdeDataType.Numeric),
        new JdeField("PSURAB", "PSURAB", JdeDataType.Numeric),
        new JdeField("PSURRF", "PSURRF", JdeDataType.String, 30),
        new JdeField("PSTORG", "PSTORG", JdeDataType.String, 20),
        new JdeField("PSUSER", "PSUSER", JdeDataType.String, 20),
        new JdeField("PSJOBN", "PSJOBN", JdeDataType.String, 20),
        new JdeField("PSPID", "PSPID", JdeDataType.String, 20),
        new JdeField("PSDFEFDT", "PSDFEFDT", JdeDataType.Numeric),
        new JdeField("PSDFLNID", "PSDFLNID", JdeDataType.Numeric),
        new JdeField("PSKLBMSG", "PSKLBMSG", JdeDataType.String, 20),
        new JdeField("PSUUPMJ", "PSUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31K22_0", "Primary Key on PSFSCID, PSPMAPID, PSCMITM, PSBOSTR, PSFDCMCU, PSDFCLOC, PSDFSMCU, PSDFSLOC, PSSUPN", new[] { "PSFSCID", "PSPMAPID", "PSCMITM", "PSBOSTR", "PSFDCMCU", "PSDFCLOC", "PSDFSMCU", "PSDFSLOC", "PSSUPN" }, isUnique: true, isPrimaryKey: true)
    };
}
