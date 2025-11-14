using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31K25 - .
/// </summary>
public class FF31K25 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KMFSCID.
        /// </summary>
        public const string KMFSCID = "KMFSCID";

        /// <summary>
        /// KMCMITM.
        /// </summary>
        public const string KMCMITM = "KMCMITM";

        /// <summary>
        /// KMBOSTR.
        /// </summary>
        public const string KMBOSTR = "KMBOSTR";

        /// <summary>
        /// KMPCODE.
        /// </summary>
        public const string KMPCODE = "KMPCODE";

        /// <summary>
        /// KMDFSMCU.
        /// </summary>
        public const string KMDFSMCU = "KMDFSMCU";

        /// <summary>
        /// KMDFSLOC.
        /// </summary>
        public const string KMDFSLOC = "KMDFSLOC";

        /// <summary>
        /// KMFDCMCU.
        /// </summary>
        public const string KMFDCMCU = "KMFDCMCU";

        /// <summary>
        /// KMDFCLOC.
        /// </summary>
        public const string KMDFCLOC = "KMDFCLOC";

        /// <summary>
        /// KMSUPN.
        /// </summary>
        public const string KMSUPN = "KMSUPN";

        /// <summary>
        /// KMLNDSID.
        /// </summary>
        public const string KMLNDSID = "KMLNDSID";

        /// <summary>
        /// KMREPHRS.
        /// </summary>
        public const string KMREPHRS = "KMREPHRS";

        /// <summary>
        /// KMKANFAS.
        /// </summary>
        public const string KMKANFAS = "KMKANFAS";

        /// <summary>
        /// KMKNOREP.
        /// </summary>
        public const string KMKNOREP = "KMKNOREP";

        /// <summary>
        /// KMDFREPT.
        /// </summary>
        public const string KMDFREPT = "KMDFREPT";

        /// <summary>
        /// KMDFEFDT.
        /// </summary>
        public const string KMDFEFDT = "KMDFEFDT";

        /// <summary>
        /// KMDFKQTY.
        /// </summary>
        public const string KMDFKQTY = "KMDFKQTY";

        /// <summary>
        /// KMDMKMQT.
        /// </summary>
        public const string KMDMKMQT = "KMDMKMQT";

        /// <summary>
        /// KMKANUOM.
        /// </summary>
        public const string KMKANUOM = "KMKANUOM";

        /// <summary>
        /// KMKFRIP.
        /// </summary>
        public const string KMKFRIP = "KMKFRIP";

        /// <summary>
        /// KMDFNC.
        /// </summary>
        public const string KMDFNC = "KMDFNC";

        /// <summary>
        /// KMDFKRAC.
        /// </summary>
        public const string KMDFKRAC = "KMDFKRAC";

        /// <summary>
        /// KMDFMNOB.
        /// </summary>
        public const string KMDFMNOB = "KMDFMNOB";

        /// <summary>
        /// KMDFLNID.
        /// </summary>
        public const string KMDFLNID = "KMDFLNID";

        /// <summary>
        /// KMERRC.
        /// </summary>
        public const string KMERRC = "KMERRC";

        /// <summary>
        /// KMDTAI.
        /// </summary>
        public const string KMDTAI = "KMDTAI";

        /// <summary>
        /// KMURRF.
        /// </summary>
        public const string KMURRF = "KMURRF";

        /// <summary>
        /// KMURDT.
        /// </summary>
        public const string KMURDT = "KMURDT";

        /// <summary>
        /// KMURAB.
        /// </summary>
        public const string KMURAB = "KMURAB";

        /// <summary>
        /// KMURAT.
        /// </summary>
        public const string KMURAT = "KMURAT";

        /// <summary>
        /// KMURCD.
        /// </summary>
        public const string KMURCD = "KMURCD";

        /// <summary>
        /// KMPID.
        /// </summary>
        public const string KMPID = "KMPID";

        /// <summary>
        /// KMTORG.
        /// </summary>
        public const string KMTORG = "KMTORG";

        /// <summary>
        /// KMUSER.
        /// </summary>
        public const string KMUSER = "KMUSER";

        /// <summary>
        /// KMJOBN.
        /// </summary>
        public const string KMJOBN = "KMJOBN";

        /// <summary>
        /// KMUUPMJ.
        /// </summary>
        public const string KMUUPMJ = "KMUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF31K25";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KMFSCID", "KMFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("KMCMITM", "KMCMITM", JdeDataType.Numeric, null, true, true),
        new JdeField("KMBOSTR", "KMBOSTR", JdeDataType.String, 8, true, true),
        new JdeField("KMPCODE", "KMPCODE", JdeDataType.String, 4),
        new JdeField("KMDFSMCU", "KMDFSMCU", JdeDataType.String, 24, true, true),
        new JdeField("KMDFSLOC", "KMDFSLOC", JdeDataType.String, 40, true, true),
        new JdeField("KMFDCMCU", "KMFDCMCU", JdeDataType.String, 24, true, true),
        new JdeField("KMDFCLOC", "KMDFCLOC", JdeDataType.String, 40, true, true),
        new JdeField("KMSUPN", "KMSUPN", JdeDataType.Numeric, null, true, true),
        new JdeField("KMLNDSID", "KMLNDSID", JdeDataType.Numeric),
        new JdeField("KMREPHRS", "KMREPHRS", JdeDataType.Numeric),
        new JdeField("KMKANFAS", "KMKANFAS", JdeDataType.Numeric),
        new JdeField("KMKNOREP", "KMKNOREP", JdeDataType.String, 2),
        new JdeField("KMDFREPT", "KMDFREPT", JdeDataType.String, 2),
        new JdeField("KMDFEFDT", "KMDFEFDT", JdeDataType.Numeric),
        new JdeField("KMDFKQTY", "KMDFKQTY", JdeDataType.Numeric),
        new JdeField("KMDMKMQT", "KMDMKMQT", JdeDataType.Numeric),
        new JdeField("KMKANUOM", "KMKANUOM", JdeDataType.String, 4),
        new JdeField("KMKFRIP", "KMKFRIP", JdeDataType.String, 2),
        new JdeField("KMDFNC", "KMDFNC", JdeDataType.Numeric),
        new JdeField("KMDFKRAC", "KMDFKRAC", JdeDataType.String, 2),
        new JdeField("KMDFMNOB", "KMDFMNOB", JdeDataType.Numeric),
        new JdeField("KMDFLNID", "KMDFLNID", JdeDataType.Numeric),
        new JdeField("KMERRC", "KMERRC", JdeDataType.String, 2),
        new JdeField("KMDTAI", "KMDTAI", JdeDataType.String, 20),
        new JdeField("KMURRF", "KMURRF", JdeDataType.String, 30),
        new JdeField("KMURDT", "KMURDT", JdeDataType.Numeric),
        new JdeField("KMURAB", "KMURAB", JdeDataType.Numeric),
        new JdeField("KMURAT", "KMURAT", JdeDataType.Numeric),
        new JdeField("KMURCD", "KMURCD", JdeDataType.String, 4),
        new JdeField("KMPID", "KMPID", JdeDataType.String, 20),
        new JdeField("KMTORG", "KMTORG", JdeDataType.String, 20),
        new JdeField("KMUSER", "KMUSER", JdeDataType.String, 20),
        new JdeField("KMJOBN", "KMJOBN", JdeDataType.String, 20),
        new JdeField("KMUUPMJ", "KMUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31K25_0", "Primary Key on KMFSCID, KMCMITM, KMBOSTR, KMDFSMCU, KMDFSLOC, KMFDCMCU, KMDFCLOC, KMSUPN", new[] { "KMFSCID", "KMCMITM", "KMBOSTR", "KMDFSMCU", "KMDFSLOC", "KMFDCMCU", "KMDFCLOC", "KMSUPN" }, isUnique: true, isPrimaryKey: true)
    };
}
