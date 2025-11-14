using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49633 - .
/// </summary>
public class F49633 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IQLDNM.
        /// </summary>
        public const string IQLDNM = "IQLDNM";

        /// <summary>
        /// IQVMCU.
        /// </summary>
        public const string IQVMCU = "IQVMCU";

        /// <summary>
        /// IQDLNO.
        /// </summary>
        public const string IQDLNO = "IQDLNO";

        /// <summary>
        /// IQSHPN.
        /// </summary>
        public const string IQSHPN = "IQSHPN";

        /// <summary>
        /// IQRSSN.
        /// </summary>
        public const string IQRSSN = "IQRSSN";

        /// <summary>
        /// IQRTN.
        /// </summary>
        public const string IQRTN = "IQRTN";

        /// <summary>
        /// IQANCC.
        /// </summary>
        public const string IQANCC = "IQANCC";

        /// <summary>
        /// IQWTCA.
        /// </summary>
        public const string IQWTCA = "IQWTCA";

        /// <summary>
        /// IQWTUM.
        /// </summary>
        public const string IQWTUM = "IQWTUM";

        /// <summary>
        /// IQVLCP.
        /// </summary>
        public const string IQVLCP = "IQVLCP";

        /// <summary>
        /// IQVLUM.
        /// </summary>
        public const string IQVLUM = "IQVLUM";

        /// <summary>
        /// IQCCUB.
        /// </summary>
        public const string IQCCUB = "IQCCUB";

        /// <summary>
        /// IQLGTS.
        /// </summary>
        public const string IQLGTS = "IQLGTS";

        /// <summary>
        /// IQWTHS.
        /// </summary>
        public const string IQWTHS = "IQWTHS";

        /// <summary>
        /// IQHGTS.
        /// </summary>
        public const string IQHGTS = "IQHGTS";

        /// <summary>
        /// IQGTHS.
        /// </summary>
        public const string IQGTHS = "IQGTHS";

        /// <summary>
        /// IQLUOM.
        /// </summary>
        public const string IQLUOM = "IQLUOM";

        /// <summary>
        /// IQNPCS.
        /// </summary>
        public const string IQNPCS = "IQNPCS";

        /// <summary>
        /// IQNCTR.
        /// </summary>
        public const string IQNCTR = "IQNCTR";

        /// <summary>
        /// IQDSTN.
        /// </summary>
        public const string IQDSTN = "IQDSTN";

        /// <summary>
        /// IQUMD1.
        /// </summary>
        public const string IQUMD1 = "IQUMD1";

        /// <summary>
        /// IQDSRC.
        /// </summary>
        public const string IQDSRC = "IQDSRC";

        /// <summary>
        /// IQFRCF.
        /// </summary>
        public const string IQFRCF = "IQFRCF";

        /// <summary>
        /// IQFRCC.
        /// </summary>
        public const string IQFRCC = "IQFRCC";

        /// <summary>
        /// IQECST.
        /// </summary>
        public const string IQECST = "IQECST";

        /// <summary>
        /// IQAEXP.
        /// </summary>
        public const string IQAEXP = "IQAEXP";

        /// <summary>
        /// IQFEA.
        /// </summary>
        public const string IQFEA = "IQFEA";

        /// <summary>
        /// IQCRCD.
        /// </summary>
        public const string IQCRCD = "IQCRCD";

        /// <summary>
        /// IQURCD.
        /// </summary>
        public const string IQURCD = "IQURCD";

        /// <summary>
        /// IQURDT.
        /// </summary>
        public const string IQURDT = "IQURDT";

        /// <summary>
        /// IQURAT.
        /// </summary>
        public const string IQURAT = "IQURAT";

        /// <summary>
        /// IQURAB.
        /// </summary>
        public const string IQURAB = "IQURAB";

        /// <summary>
        /// IQURRF.
        /// </summary>
        public const string IQURRF = "IQURRF";

        /// <summary>
        /// IQUSER.
        /// </summary>
        public const string IQUSER = "IQUSER";

        /// <summary>
        /// IQPID.
        /// </summary>
        public const string IQPID = "IQPID";

        /// <summary>
        /// IQJOBN.
        /// </summary>
        public const string IQJOBN = "IQJOBN";

        /// <summary>
        /// IQUPMJ.
        /// </summary>
        public const string IQUPMJ = "IQUPMJ";

        /// <summary>
        /// IQTDAY.
        /// </summary>
        public const string IQTDAY = "IQTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49633";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IQLDNM", "IQLDNM", JdeDataType.Numeric, null, true, true),
        new JdeField("IQVMCU", "IQVMCU", JdeDataType.String, 24, true, true),
        new JdeField("IQDLNO", "IQDLNO", JdeDataType.Numeric, null, true, true),
        new JdeField("IQSHPN", "IQSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("IQRSSN", "IQRSSN", JdeDataType.Numeric),
        new JdeField("IQRTN", "IQRTN", JdeDataType.Numeric),
        new JdeField("IQANCC", "IQANCC", JdeDataType.Numeric),
        new JdeField("IQWTCA", "IQWTCA", JdeDataType.Numeric),
        new JdeField("IQWTUM", "IQWTUM", JdeDataType.String, 4),
        new JdeField("IQVLCP", "IQVLCP", JdeDataType.Numeric),
        new JdeField("IQVLUM", "IQVLUM", JdeDataType.String, 4),
        new JdeField("IQCCUB", "IQCCUB", JdeDataType.Numeric),
        new JdeField("IQLGTS", "IQLGTS", JdeDataType.Numeric),
        new JdeField("IQWTHS", "IQWTHS", JdeDataType.Numeric),
        new JdeField("IQHGTS", "IQHGTS", JdeDataType.Numeric),
        new JdeField("IQGTHS", "IQGTHS", JdeDataType.Numeric),
        new JdeField("IQLUOM", "IQLUOM", JdeDataType.String, 4),
        new JdeField("IQNPCS", "IQNPCS", JdeDataType.Numeric),
        new JdeField("IQNCTR", "IQNCTR", JdeDataType.Numeric),
        new JdeField("IQDSTN", "IQDSTN", JdeDataType.Numeric),
        new JdeField("IQUMD1", "IQUMD1", JdeDataType.String, 4),
        new JdeField("IQDSRC", "IQDSRC", JdeDataType.String, 2),
        new JdeField("IQFRCF", "IQFRCF", JdeDataType.Numeric),
        new JdeField("IQFRCC", "IQFRCC", JdeDataType.Numeric),
        new JdeField("IQECST", "IQECST", JdeDataType.Numeric),
        new JdeField("IQAEXP", "IQAEXP", JdeDataType.Numeric),
        new JdeField("IQFEA", "IQFEA", JdeDataType.Numeric),
        new JdeField("IQCRCD", "IQCRCD", JdeDataType.String, 6),
        new JdeField("IQURCD", "IQURCD", JdeDataType.String, 4),
        new JdeField("IQURDT", "IQURDT", JdeDataType.Numeric),
        new JdeField("IQURAT", "IQURAT", JdeDataType.Numeric),
        new JdeField("IQURAB", "IQURAB", JdeDataType.Numeric),
        new JdeField("IQURRF", "IQURRF", JdeDataType.String, 30),
        new JdeField("IQUSER", "IQUSER", JdeDataType.String, 20),
        new JdeField("IQPID", "IQPID", JdeDataType.String, 20),
        new JdeField("IQJOBN", "IQJOBN", JdeDataType.String, 20),
        new JdeField("IQUPMJ", "IQUPMJ", JdeDataType.Numeric),
        new JdeField("IQTDAY", "IQTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49633_0", "Primary Key on IQLDNM, IQVMCU, IQDLNO, IQSHPN", new[] { "IQLDNM", "IQVMCU", "IQDLNO", "IQSHPN" }, isUnique: true, isPrimaryKey: true)
    };
}
