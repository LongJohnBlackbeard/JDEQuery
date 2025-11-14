using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F050116W - .
/// </summary>
public class F050116W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EMASMTGUID.
        /// </summary>
        public const string EMASMTGUID = "EMASMTGUID";

        /// <summary>
        /// EMAN8.
        /// </summary>
        public const string EMAN8 = "EMAN8";

        /// <summary>
        /// EMHMCU.
        /// </summary>
        public const string EMHMCU = "EMHMCU";

        /// <summary>
        /// EMEFTO.
        /// </summary>
        public const string EMEFTO = "EMEFTO";

        /// <summary>
        /// EMSEQ#.
        /// </summary>
        public const string EMSEQ_ = "EMSEQ#";

        /// <summary>
        /// EMTRS.
        /// </summary>
        public const string EMTRS = "EMTRS";

        /// <summary>
        /// EMJBCD.
        /// </summary>
        public const string EMJBCD = "EMJBCD";

        /// <summary>
        /// EMJBST.
        /// </summary>
        public const string EMJBST = "EMJBST";

        /// <summary>
        /// EMPFRQ.
        /// </summary>
        public const string EMPFRQ = "EMPFRQ";

        /// <summary>
        /// EMCO.
        /// </summary>
        public const string EMCO = "EMCO";

        /// <summary>
        /// EMPOS.
        /// </summary>
        public const string EMPOS = "EMPOS";

        /// <summary>
        /// EMPGRD.
        /// </summary>
        public const string EMPGRD = "EMPGRD";

        /// <summary>
        /// EMUN.
        /// </summary>
        public const string EMUN = "EMUN";

        /// <summary>
        /// EMSALY.
        /// </summary>
        public const string EMSALY = "EMSALY";

        /// <summary>
        /// EMSLOC.
        /// </summary>
        public const string EMSLOC = "EMSLOC";

        /// <summary>
        /// EMPHRT.
        /// </summary>
        public const string EMPHRT = "EMPHRT";

        /// <summary>
        /// EMSAL.
        /// </summary>
        public const string EMSAL = "EMSAL";

        /// <summary>
        /// EMPSDT.
        /// </summary>
        public const string EMPSDT = "EMPSDT";

        /// <summary>
        /// EMPTDT.
        /// </summary>
        public const string EMPTDT = "EMPTDT";

        /// <summary>
        /// EMNRVW.
        /// </summary>
        public const string EMNRVW = "EMNRVW";

        /// <summary>
        /// EMSALAPP.
        /// </summary>
        public const string EMSALAPP = "EMSALAPP";

        /// <summary>
        /// EMUPMJ.
        /// </summary>
        public const string EMUPMJ = "EMUPMJ";

        /// <summary>
        /// EMUPMT.
        /// </summary>
        public const string EMUPMT = "EMUPMT";

        /// <summary>
        /// EMUSER.
        /// </summary>
        public const string EMUSER = "EMUSER";

        /// <summary>
        /// EMMKEY.
        /// </summary>
        public const string EMMKEY = "EMMKEY";

        /// <summary>
        /// EMPID.
        /// </summary>
        public const string EMPID = "EMPID";

        /// <summary>
        /// EMRCPRC.
        /// </summary>
        public const string EMRCPRC = "EMRCPRC";
    }

    /// <inheritdoc />
    public override string TableName => "F050116W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EMASMTGUID", "EMASMTGUID", JdeDataType.String, 100),
        new JdeField("EMAN8", "EMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EMHMCU", "EMHMCU", JdeDataType.String, 24, true, true),
        new JdeField("EMEFTO", "EMEFTO", JdeDataType.Numeric, null, true, true),
        new JdeField("EMSEQ#", "EMSEQ#", JdeDataType.Numeric, null, true, true),
        new JdeField("EMTRS", "EMTRS", JdeDataType.String, 6, true, true),
        new JdeField("EMJBCD", "EMJBCD", JdeDataType.String, 12, true, true),
        new JdeField("EMJBST", "EMJBST", JdeDataType.String, 8, true, true),
        new JdeField("EMPFRQ", "EMPFRQ", JdeDataType.String, 2),
        new JdeField("EMCO", "EMCO", JdeDataType.String, 10),
        new JdeField("EMPOS", "EMPOS", JdeDataType.String, 16),
        new JdeField("EMPGRD", "EMPGRD", JdeDataType.String, 12),
        new JdeField("EMUN", "EMUN", JdeDataType.String, 12),
        new JdeField("EMSALY", "EMSALY", JdeDataType.String, 2),
        new JdeField("EMSLOC", "EMSLOC", JdeDataType.String, 16),
        new JdeField("EMPHRT", "EMPHRT", JdeDataType.Numeric),
        new JdeField("EMSAL", "EMSAL", JdeDataType.Numeric),
        new JdeField("EMPSDT", "EMPSDT", JdeDataType.Numeric),
        new JdeField("EMPTDT", "EMPTDT", JdeDataType.Numeric),
        new JdeField("EMNRVW", "EMNRVW", JdeDataType.Numeric),
        new JdeField("EMSALAPP", "EMSALAPP", JdeDataType.String, 2),
        new JdeField("EMUPMJ", "EMUPMJ", JdeDataType.Numeric),
        new JdeField("EMUPMT", "EMUPMT", JdeDataType.Numeric),
        new JdeField("EMUSER", "EMUSER", JdeDataType.String, 20),
        new JdeField("EMMKEY", "EMMKEY", JdeDataType.String, 30),
        new JdeField("EMPID", "EMPID", JdeDataType.String, 20),
        new JdeField("EMRCPRC", "EMRCPRC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F050116W_0", "Primary Key on EMAN8, EMHMCU, EMEFTO, EMSEQ#, EMTRS, EMJBCD, EMJBST", new[] { "EMAN8", "EMHMCU", "EMEFTO", "EMSEQ#", "EMTRS", "EMJBCD", "EMJBST" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F050116W_2", "Index on EMASMTGUID, EMEFTO, EMSEQ#", new[] { "EMASMTGUID", "EMEFTO", "EMSEQ#" })
    };
}
