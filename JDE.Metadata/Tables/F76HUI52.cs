using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76HUI52 - .
/// </summary>
public class F76HUI52 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DRCTID.
        /// </summary>
        public const string DRCTID = "DRCTID";

        /// <summary>
        /// DRJOBS.
        /// </summary>
        public const string DRJOBS = "DRJOBS";

        /// <summary>
        /// DRH76LOPN.
        /// </summary>
        public const string DRH76LOPN = "DRH76LOPN";

        /// <summary>
        /// DRH76LECO.
        /// </summary>
        public const string DRH76LECO = "DRH76LECO";

        /// <summary>
        /// DRH76LEDT.
        /// </summary>
        public const string DRH76LEDT = "DRH76LEDT";

        /// <summary>
        /// DRH76EMS.
        /// </summary>
        public const string DRH76EMS = "DRH76EMS";

        /// <summary>
        /// DRKCO.
        /// </summary>
        public const string DRKCO = "DRKCO";

        /// <summary>
        /// DRDCT.
        /// </summary>
        public const string DRDCT = "DRDCT";

        /// <summary>
        /// DRDOC.
        /// </summary>
        public const string DRDOC = "DRDOC";

        /// <summary>
        /// DRACTI.
        /// </summary>
        public const string DRACTI = "DRACTI";

        /// <summary>
        /// DRH76LIST.
        /// </summary>
        public const string DRH76LIST = "DRH76LIST";

        /// <summary>
        /// DRGLC.
        /// </summary>
        public const string DRGLC = "DRGLC";

        /// <summary>
        /// DRH76LENU.
        /// </summary>
        public const string DRH76LENU = "DRH76LENU";

        /// <summary>
        /// DRH76NNFR.
        /// </summary>
        public const string DRH76NNFR = "DRH76NNFR";
    }

    /// <inheritdoc />
    public override string TableName => "F76HUI52";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DRCTID", "DRCTID", JdeDataType.String, 30, true, true),
        new JdeField("DRJOBS", "DRJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("DRH76LOPN", "DRH76LOPN", JdeDataType.Numeric, null, true, true),
        new JdeField("DRH76LECO", "DRH76LECO", JdeDataType.String, 10, true, true),
        new JdeField("DRH76LEDT", "DRH76LEDT", JdeDataType.String, 6, true, true),
        new JdeField("DRH76EMS", "DRH76EMS", JdeDataType.String, 8, true, true),
        new JdeField("DRKCO", "DRKCO", JdeDataType.String, 10, true, true),
        new JdeField("DRDCT", "DRDCT", JdeDataType.String, 4, true, true),
        new JdeField("DRDOC", "DRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DRACTI", "DRACTI", JdeDataType.String, 2),
        new JdeField("DRH76LIST", "DRH76LIST", JdeDataType.String, 2),
        new JdeField("DRGLC", "DRGLC", JdeDataType.String, 8),
        new JdeField("DRH76LENU", "DRH76LENU", JdeDataType.Numeric),
        new JdeField("DRH76NNFR", "DRH76NNFR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76HUI52_0", "Primary Key on DRCTID, DRJOBS, DRH76LOPN, DRH76LECO, DRH76LEDT, DRH76EMS, DRKCO, DRDCT, DRDOC", new[] { "DRCTID", "DRJOBS", "DRH76LOPN", "DRH76LECO", "DRH76LEDT", "DRH76EMS", "DRKCO", "DRDCT", "DRDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
