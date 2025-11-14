using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B04 - .
/// </summary>
public class F31B04 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MTMATYP.
        /// </summary>
        public const string MTMATYP = "MTMATYP";

        /// <summary>
        /// MTSMTYP.
        /// </summary>
        public const string MTSMTYP = "MTSMTYP";

        /// <summary>
        /// MTDSCMT.
        /// </summary>
        public const string MTDSCMT = "MTDSCMT";

        /// <summary>
        /// MTDSCSMT.
        /// </summary>
        public const string MTDSCSMT = "MTDSCSMT";

        /// <summary>
        /// MTMTUOM.
        /// </summary>
        public const string MTMTUOM = "MTMTUOM";

        /// <summary>
        /// MTUPALC.
        /// </summary>
        public const string MTUPALC = "MTUPALC";

        /// <summary>
        /// MTLOALC.
        /// </summary>
        public const string MTLOALC = "MTLOALC";

        /// <summary>
        /// MTITM.
        /// </summary>
        public const string MTITM = "MTITM";

        /// <summary>
        /// MTUSER.
        /// </summary>
        public const string MTUSER = "MTUSER";

        /// <summary>
        /// MTPID.
        /// </summary>
        public const string MTPID = "MTPID";

        /// <summary>
        /// MTTDAY.
        /// </summary>
        public const string MTTDAY = "MTTDAY";

        /// <summary>
        /// MTUPMJ.
        /// </summary>
        public const string MTUPMJ = "MTUPMJ";

        /// <summary>
        /// MTMATST.
        /// </summary>
        public const string MTMATST = "MTMATST";

        /// <summary>
        /// MTMTCOMM.
        /// </summary>
        public const string MTMTCOMM = "MTMTCOMM";

        /// <summary>
        /// MTMTFF.
        /// </summary>
        public const string MTMTFF = "MTMTFF";

        /// <summary>
        /// MTMTTC.
        /// </summary>
        public const string MTMTTC = "MTMTTC";

        /// <summary>
        /// MTWSPIND.
        /// </summary>
        public const string MTWSPIND = "MTWSPIND";

        /// <summary>
        /// MTSTDTEMP.
        /// </summary>
        public const string MTSTDTEMP = "MTSTDTEMP";

        /// <summary>
        /// MTTEMPUOM.
        /// </summary>
        public const string MTTEMPUOM = "MTTEMPUOM";

        /// <summary>
        /// MTWCCCNAME.
        /// </summary>
        public const string MTWCCCNAME = "MTWCCCNAME";

        /// <summary>
        /// MTWCCID.
        /// </summary>
        public const string MTWCCID = "MTWCCID";

        /// <summary>
        /// MTWCCCIND.
        /// </summary>
        public const string MTWCCCIND = "MTWCCCIND";

        /// <summary>
        /// MTMATCALID.
        /// </summary>
        public const string MTMATCALID = "MTMATCALID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B04";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MTMATYP", "MTMATYP", JdeDataType.String, 8, true, true),
        new JdeField("MTSMTYP", "MTSMTYP", JdeDataType.String, 8),
        new JdeField("MTDSCMT", "MTDSCMT", JdeDataType.String, 60),
        new JdeField("MTDSCSMT", "MTDSCSMT", JdeDataType.String, 60),
        new JdeField("MTMTUOM", "MTMTUOM", JdeDataType.String, 4),
        new JdeField("MTUPALC", "MTUPALC", JdeDataType.Numeric),
        new JdeField("MTLOALC", "MTLOALC", JdeDataType.Numeric),
        new JdeField("MTITM", "MTITM", JdeDataType.Numeric),
        new JdeField("MTUSER", "MTUSER", JdeDataType.String, 20),
        new JdeField("MTPID", "MTPID", JdeDataType.String, 20),
        new JdeField("MTTDAY", "MTTDAY", JdeDataType.Numeric),
        new JdeField("MTUPMJ", "MTUPMJ", JdeDataType.Numeric),
        new JdeField("MTMATST", "MTMATST", JdeDataType.String, 2),
        new JdeField("MTMTCOMM", "MTMTCOMM", JdeDataType.String, 60),
        new JdeField("MTMTFF", "MTMTFF", JdeDataType.String, 2),
        new JdeField("MTMTTC", "MTMTTC", JdeDataType.String, 6),
        new JdeField("MTWSPIND", "MTWSPIND", JdeDataType.String, 2),
        new JdeField("MTSTDTEMP", "MTSTDTEMP", JdeDataType.Numeric),
        new JdeField("MTTEMPUOM", "MTTEMPUOM", JdeDataType.String, 4),
        new JdeField("MTWCCCNAME", "MTWCCCNAME", JdeDataType.String, 64),
        new JdeField("MTWCCID", "MTWCCID", JdeDataType.Numeric),
        new JdeField("MTWCCCIND", "MTWCCCIND", JdeDataType.String, 2),
        new JdeField("MTMATCALID", "MTMATCALID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B04_0", "Primary Key on MTMATYP", new[] { "MTMATYP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B04_2", "Index on MTWCCID", new[] { "MTWCCID" })
    };
}
