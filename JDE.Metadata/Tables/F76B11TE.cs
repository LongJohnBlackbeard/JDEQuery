using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B11TE - .
/// </summary>
public class F76B11TE : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FDBNNF.
        /// </summary>
        public const string FDBNNF = "FDBNNF";

        /// <summary>
        /// FDBSER.
        /// </summary>
        public const string FDBSER = "FDBSER";

        /// <summary>
        /// FDN001.
        /// </summary>
        public const string FDN001 = "FDN001";

        /// <summary>
        /// FDDCT.
        /// </summary>
        public const string FDDCT = "FDDCT";

        /// <summary>
        /// FDUKID.
        /// </summary>
        public const string FDUKID = "FDUKID";

        /// <summary>
        /// FDB76EPSS.
        /// </summary>
        public const string FDB76EPSS = "FDB76EPSS";

        /// <summary>
        /// FDB76EPIC.
        /// </summary>
        public const string FDB76EPIC = "FDB76EPIC";

        /// <summary>
        /// FDB76EPIR.
        /// </summary>
        public const string FDB76EPIR = "FDB76EPIR";

        /// <summary>
        /// FDB76EPIS.
        /// </summary>
        public const string FDB76EPIS = "FDB76EPIS";

        /// <summary>
        /// FDB76EPIP.
        /// </summary>
        public const string FDB76EPIP = "FDB76EPIP";

        /// <summary>
        /// FDB76EPPI.
        /// </summary>
        public const string FDB76EPPI = "FDB76EPPI";

        /// <summary>
        /// FDB76EPCO.
        /// </summary>
        public const string FDB76EPCO = "FDB76EPCO";

        /// <summary>
        /// FDB76ECSS.
        /// </summary>
        public const string FDB76ECSS = "FDB76ECSS";

        /// <summary>
        /// FDB76ECIC.
        /// </summary>
        public const string FDB76ECIC = "FDB76ECIC";

        /// <summary>
        /// FDB76ECIR.
        /// </summary>
        public const string FDB76ECIR = "FDB76ECIR";

        /// <summary>
        /// FDB76ECIS.
        /// </summary>
        public const string FDB76ECIS = "FDB76ECIS";

        /// <summary>
        /// FDB76ECIP.
        /// </summary>
        public const string FDB76ECIP = "FDB76ECIP";

        /// <summary>
        /// FDB76ECPI.
        /// </summary>
        public const string FDB76ECPI = "FDB76ECPI";

        /// <summary>
        /// FDB76ECCO.
        /// </summary>
        public const string FDB76ECCO = "FDB76ECCO";

        /// <summary>
        /// FDB76EGA1.
        /// </summary>
        public const string FDB76EGA1 = "FDB76EGA1";

        /// <summary>
        /// FDB76EGA2.
        /// </summary>
        public const string FDB76EGA2 = "FDB76EGA2";

        /// <summary>
        /// FDB76EGA3.
        /// </summary>
        public const string FDB76EGA3 = "FDB76EGA3";

        /// <summary>
        /// FDB76EGA4.
        /// </summary>
        public const string FDB76EGA4 = "FDB76EGA4";

        /// <summary>
        /// FDB76EGD1.
        /// </summary>
        public const string FDB76EGD1 = "FDB76EGD1";

        /// <summary>
        /// FDB76EGD2.
        /// </summary>
        public const string FDB76EGD2 = "FDB76EGD2";

        /// <summary>
        /// FDB76EGS1.
        /// </summary>
        public const string FDB76EGS1 = "FDB76EGS1";

        /// <summary>
        /// FDB76EAA.
        /// </summary>
        public const string FDB76EAA = "FDB76EAA";

        /// <summary>
        /// FDURCD.
        /// </summary>
        public const string FDURCD = "FDURCD";

        /// <summary>
        /// FDURDT.
        /// </summary>
        public const string FDURDT = "FDURDT";

        /// <summary>
        /// FDURAT.
        /// </summary>
        public const string FDURAT = "FDURAT";

        /// <summary>
        /// FDURRF.
        /// </summary>
        public const string FDURRF = "FDURRF";

        /// <summary>
        /// FDUSER.
        /// </summary>
        public const string FDUSER = "FDUSER";

        /// <summary>
        /// FDPID.
        /// </summary>
        public const string FDPID = "FDPID";

        /// <summary>
        /// FDJOBN.
        /// </summary>
        public const string FDJOBN = "FDJOBN";

        /// <summary>
        /// FDUPMJ.
        /// </summary>
        public const string FDUPMJ = "FDUPMJ";

        /// <summary>
        /// FDTDAY.
        /// </summary>
        public const string FDTDAY = "FDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76B11TE";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FDBNNF", "FDBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("FDBSER", "FDBSER", JdeDataType.String, 4, true, true),
        new JdeField("FDN001", "FDN001", JdeDataType.Numeric, null, true, true),
        new JdeField("FDDCT", "FDDCT", JdeDataType.String, 4, true, true),
        new JdeField("FDUKID", "FDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("FDB76EPSS", "FDB76EPSS", JdeDataType.Numeric),
        new JdeField("FDB76EPIC", "FDB76EPIC", JdeDataType.Numeric),
        new JdeField("FDB76EPIR", "FDB76EPIR", JdeDataType.Numeric),
        new JdeField("FDB76EPIS", "FDB76EPIS", JdeDataType.Numeric),
        new JdeField("FDB76EPIP", "FDB76EPIP", JdeDataType.Numeric),
        new JdeField("FDB76EPPI", "FDB76EPPI", JdeDataType.Numeric),
        new JdeField("FDB76EPCO", "FDB76EPCO", JdeDataType.Numeric),
        new JdeField("FDB76ECSS", "FDB76ECSS", JdeDataType.Numeric),
        new JdeField("FDB76ECIC", "FDB76ECIC", JdeDataType.Numeric),
        new JdeField("FDB76ECIR", "FDB76ECIR", JdeDataType.Numeric),
        new JdeField("FDB76ECIS", "FDB76ECIS", JdeDataType.Numeric),
        new JdeField("FDB76ECIP", "FDB76ECIP", JdeDataType.Numeric),
        new JdeField("FDB76ECPI", "FDB76ECPI", JdeDataType.Numeric),
        new JdeField("FDB76ECCO", "FDB76ECCO", JdeDataType.Numeric),
        new JdeField("FDB76EGA1", "FDB76EGA1", JdeDataType.Numeric),
        new JdeField("FDB76EGA2", "FDB76EGA2", JdeDataType.Numeric),
        new JdeField("FDB76EGA3", "FDB76EGA3", JdeDataType.Numeric),
        new JdeField("FDB76EGA4", "FDB76EGA4", JdeDataType.Numeric),
        new JdeField("FDB76EGD1", "FDB76EGD1", JdeDataType.Numeric),
        new JdeField("FDB76EGD2", "FDB76EGD2", JdeDataType.Numeric),
        new JdeField("FDB76EGS1", "FDB76EGS1", JdeDataType.String, 60),
        new JdeField("FDB76EAA", "FDB76EAA", JdeDataType.String),
        new JdeField("FDURCD", "FDURCD", JdeDataType.String, 4),
        new JdeField("FDURDT", "FDURDT", JdeDataType.Numeric),
        new JdeField("FDURAT", "FDURAT", JdeDataType.Numeric),
        new JdeField("FDURRF", "FDURRF", JdeDataType.String, 30),
        new JdeField("FDUSER", "FDUSER", JdeDataType.String, 20),
        new JdeField("FDPID", "FDPID", JdeDataType.String, 20),
        new JdeField("FDJOBN", "FDJOBN", JdeDataType.String, 20),
        new JdeField("FDUPMJ", "FDUPMJ", JdeDataType.Numeric),
        new JdeField("FDTDAY", "FDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B11TE_0", "Primary Key on FDBNNF, FDBSER, FDN001, FDDCT, FDUKID", new[] { "FDBNNF", "FDBSER", "FDN001", "FDDCT", "FDUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
