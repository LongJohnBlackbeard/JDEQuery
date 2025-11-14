using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CG503 - .
/// </summary>
public class F90CG503 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CADOCO.
        /// </summary>
        public const string CADOCO = "CADOCO";

        /// <summary>
        /// CATFLAG.
        /// </summary>
        public const string CATFLAG = "CATFLAG";

        /// <summary>
        /// CACSEQN.
        /// </summary>
        public const string CACSEQN = "CACSEQN";

        /// <summary>
        /// CAASTYP.
        /// </summary>
        public const string CAASTYP = "CAASTYP";

        /// <summary>
        /// CADOC1.
        /// </summary>
        public const string CADOC1 = "CADOC1";

        /// <summary>
        /// CADCTO.
        /// </summary>
        public const string CADCTO = "CADCTO";

        /// <summary>
        /// CAKCOO.
        /// </summary>
        public const string CAKCOO = "CAKCOO";

        /// <summary>
        /// CALEADID.
        /// </summary>
        public const string CALEADID = "CALEADID";

        /// <summary>
        /// CARLLN.
        /// </summary>
        public const string CARLLN = "CARLLN";

        /// <summary>
        /// CASCRINSID.
        /// </summary>
        public const string CASCRINSID = "CASCRINSID";

        /// <summary>
        /// CACRTU.
        /// </summary>
        public const string CACRTU = "CACRTU";

        /// <summary>
        /// CARORN.
        /// </summary>
        public const string CARORN = "CARORN";

        /// <summary>
        /// CAPID.
        /// </summary>
        public const string CAPID = "CAPID";

        /// <summary>
        /// CAMKEY.
        /// </summary>
        public const string CAMKEY = "CAMKEY";

        /// <summary>
        /// CAUSER.
        /// </summary>
        public const string CAUSER = "CAUSER";

        /// <summary>
        /// CAUDTTM.
        /// </summary>
        public const string CAUDTTM = "CAUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CG503";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CADOCO", "CADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CATFLAG", "CATFLAG", JdeDataType.String, 2, true, true),
        new JdeField("CACSEQN", "CACSEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("CAASTYP", "CAASTYP", JdeDataType.String, 2),
        new JdeField("CADOC1", "CADOC1", JdeDataType.Numeric),
        new JdeField("CADCTO", "CADCTO", JdeDataType.String, 4),
        new JdeField("CAKCOO", "CAKCOO", JdeDataType.String, 10),
        new JdeField("CALEADID", "CALEADID", JdeDataType.Numeric),
        new JdeField("CARLLN", "CARLLN", JdeDataType.Numeric),
        new JdeField("CASCRINSID", "CASCRINSID", JdeDataType.Numeric),
        new JdeField("CACRTU", "CACRTU", JdeDataType.String, 20),
        new JdeField("CARORN", "CARORN", JdeDataType.String, 16),
        new JdeField("CAPID", "CAPID", JdeDataType.String, 20),
        new JdeField("CAMKEY", "CAMKEY", JdeDataType.String, 30),
        new JdeField("CAUSER", "CAUSER", JdeDataType.String, 20),
        new JdeField("CAUDTTM", "CAUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CG503_0", "Primary Key on CADOCO, CATFLAG, CACSEQN", new[] { "CADOCO", "CATFLAG", "CACSEQN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CG503_2", "Index on CALEADID", new[] { "CALEADID" }),
        new JdeIndex("F90CG503_3", "Index on CADOCO, CATFLAG, SYS_NC00017$", new[] { "CADOCO", "CATFLAG", "SYS_NC00017$" })
    };
}
