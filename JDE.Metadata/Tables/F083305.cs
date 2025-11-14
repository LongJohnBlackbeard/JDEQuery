using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F083305 - .
/// </summary>
public class F083305 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MMBSNM.
        /// </summary>
        public const string MMBSNM = "MMBSNM";

        /// <summary>
        /// MMEFTS.
        /// </summary>
        public const string MMEFTS = "MMEFTS";

        /// <summary>
        /// MMEFST.
        /// </summary>
        public const string MMEFST = "MMEFST";

        /// <summary>
        /// MMOBNM.
        /// </summary>
        public const string MMOBNM = "MMOBNM";

        /// <summary>
        /// MMVERS.
        /// </summary>
        public const string MMVERS = "MMVERS";

        /// <summary>
        /// MMAN8.
        /// </summary>
        public const string MMAN8 = "MMAN8";

        /// <summary>
        /// MMMLNM.
        /// </summary>
        public const string MMMLNM = "MMMLNM";

        /// <summary>
        /// MMADD1.
        /// </summary>
        public const string MMADD1 = "MMADD1";

        /// <summary>
        /// MMADD2.
        /// </summary>
        public const string MMADD2 = "MMADD2";

        /// <summary>
        /// MMADD3.
        /// </summary>
        public const string MMADD3 = "MMADD3";

        /// <summary>
        /// MMADD4.
        /// </summary>
        public const string MMADD4 = "MMADD4";

        /// <summary>
        /// MMCTY1.
        /// </summary>
        public const string MMCTY1 = "MMCTY1";

        /// <summary>
        /// MMADDS.
        /// </summary>
        public const string MMADDS = "MMADDS";

        /// <summary>
        /// MMADDZ.
        /// </summary>
        public const string MMADDZ = "MMADDZ";

        /// <summary>
        /// MMCOUN.
        /// </summary>
        public const string MMCOUN = "MMCOUN";

        /// <summary>
        /// MMSAL.
        /// </summary>
        public const string MMSAL = "MMSAL";

        /// <summary>
        /// MMSSN.
        /// </summary>
        public const string MMSSN = "MMSSN";

        /// <summary>
        /// MMDOB.
        /// </summary>
        public const string MMDOB = "MMDOB";

        /// <summary>
        /// MMDST.
        /// </summary>
        public const string MMDST = "MMDST";

        /// <summary>
        /// MMDSI.
        /// </summary>
        public const string MMDSI = "MMDSI";

        /// <summary>
        /// MMHMCU.
        /// </summary>
        public const string MMHMCU = "MMHMCU";

        /// <summary>
        /// MMJBCD.
        /// </summary>
        public const string MMJBCD = "MMJBCD";

        /// <summary>
        /// MMJBST.
        /// </summary>
        public const string MMJBST = "MMJBST";

        /// <summary>
        /// MMDL01.
        /// </summary>
        public const string MMDL01 = "MMDL01";

        /// <summary>
        /// MMMATH01.
        /// </summary>
        public const string MMMATH01 = "MMMATH01";

        /// <summary>
        /// MMMATH02.
        /// </summary>
        public const string MMMATH02 = "MMMATH02";

        /// <summary>
        /// MMDL02.
        /// </summary>
        public const string MMDL02 = "MMDL02";

        /// <summary>
        /// MMMATH03.
        /// </summary>
        public const string MMMATH03 = "MMMATH03";

        /// <summary>
        /// MMMATH04.
        /// </summary>
        public const string MMMATH04 = "MMMATH04";

        /// <summary>
        /// MMDL03.
        /// </summary>
        public const string MMDL03 = "MMDL03";

        /// <summary>
        /// MMMATH05.
        /// </summary>
        public const string MMMATH05 = "MMMATH05";

        /// <summary>
        /// MMMATH06.
        /// </summary>
        public const string MMMATH06 = "MMMATH06";

        /// <summary>
        /// MMUSER.
        /// </summary>
        public const string MMUSER = "MMUSER";

        /// <summary>
        /// MMPID.
        /// </summary>
        public const string MMPID = "MMPID";

        /// <summary>
        /// MMUPMJ.
        /// </summary>
        public const string MMUPMJ = "MMUPMJ";

        /// <summary>
        /// MMJOBN.
        /// </summary>
        public const string MMJOBN = "MMJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F083305";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MMBSNM", "MMBSNM", JdeDataType.String, 20, true, true),
        new JdeField("MMEFTS", "MMEFTS", JdeDataType.Numeric),
        new JdeField("MMEFST", "MMEFST", JdeDataType.Numeric),
        new JdeField("MMOBNM", "MMOBNM", JdeDataType.String, 20),
        new JdeField("MMVERS", "MMVERS", JdeDataType.String, 20),
        new JdeField("MMAN8", "MMAN8", JdeDataType.Numeric),
        new JdeField("MMMLNM", "MMMLNM", JdeDataType.String, 80),
        new JdeField("MMADD1", "MMADD1", JdeDataType.String, 80),
        new JdeField("MMADD2", "MMADD2", JdeDataType.String, 80),
        new JdeField("MMADD3", "MMADD3", JdeDataType.String, 80),
        new JdeField("MMADD4", "MMADD4", JdeDataType.String, 80),
        new JdeField("MMCTY1", "MMCTY1", JdeDataType.String, 50),
        new JdeField("MMADDS", "MMADDS", JdeDataType.String, 6),
        new JdeField("MMADDZ", "MMADDZ", JdeDataType.String, 24),
        new JdeField("MMCOUN", "MMCOUN", JdeDataType.String, 50),
        new JdeField("MMSAL", "MMSAL", JdeDataType.Numeric),
        new JdeField("MMSSN", "MMSSN", JdeDataType.String, 40),
        new JdeField("MMDOB", "MMDOB", JdeDataType.Numeric),
        new JdeField("MMDST", "MMDST", JdeDataType.Numeric),
        new JdeField("MMDSI", "MMDSI", JdeDataType.Numeric),
        new JdeField("MMHMCU", "MMHMCU", JdeDataType.String, 24),
        new JdeField("MMJBCD", "MMJBCD", JdeDataType.String, 12),
        new JdeField("MMJBST", "MMJBST", JdeDataType.String, 8),
        new JdeField("MMDL01", "MMDL01", JdeDataType.String, 60),
        new JdeField("MMMATH01", "MMMATH01", JdeDataType.Numeric),
        new JdeField("MMMATH02", "MMMATH02", JdeDataType.Numeric),
        new JdeField("MMDL02", "MMDL02", JdeDataType.String, 60),
        new JdeField("MMMATH03", "MMMATH03", JdeDataType.Numeric),
        new JdeField("MMMATH04", "MMMATH04", JdeDataType.Numeric),
        new JdeField("MMDL03", "MMDL03", JdeDataType.String, 60),
        new JdeField("MMMATH05", "MMMATH05", JdeDataType.Numeric),
        new JdeField("MMMATH06", "MMMATH06", JdeDataType.Numeric),
        new JdeField("MMUSER", "MMUSER", JdeDataType.String, 20),
        new JdeField("MMPID", "MMPID", JdeDataType.String, 20),
        new JdeField("MMUPMJ", "MMUPMJ", JdeDataType.Numeric),
        new JdeField("MMJOBN", "MMJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F083305_0", "Primary Key on MMBSNM", new[] { "MMBSNM" }, isUnique: true, isPrimaryKey: true)
    };
}
