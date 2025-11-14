using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7430051 - .
/// </summary>
public class F7430051 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BDUKID.
        /// </summary>
        public const string BDUKID = "BDUKID";

        /// <summary>
        /// BDK74LECO.
        /// </summary>
        public const string BDK74LECO = "BDK74LECO";

        /// <summary>
        /// BDK74LEDT.
        /// </summary>
        public const string BDK74LEDT = "BDK74LEDT";

        /// <summary>
        /// BDK74ISPL.
        /// </summary>
        public const string BDK74ISPL = "BDK74ISPL";

        /// <summary>
        /// BDKCO.
        /// </summary>
        public const string BDKCO = "BDKCO";

        /// <summary>
        /// BDDCT.
        /// </summary>
        public const string BDDCT = "BDDCT";

        /// <summary>
        /// BDDOC.
        /// </summary>
        public const string BDDOC = "BDDOC";

        /// <summary>
        /// BDK74PBST.
        /// </summary>
        public const string BDK74PBST = "BDK74PBST";
    }

    /// <inheritdoc />
    public override string TableName => "F7430051";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BDUKID", "BDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("BDK74LECO", "BDK74LECO", JdeDataType.String, 10, true, true),
        new JdeField("BDK74LEDT", "BDK74LEDT", JdeDataType.String, 10, true, true),
        new JdeField("BDK74ISPL", "BDK74ISPL", JdeDataType.String, 30, true, true),
        new JdeField("BDKCO", "BDKCO", JdeDataType.String, 10, true, true),
        new JdeField("BDDCT", "BDDCT", JdeDataType.String, 4, true, true),
        new JdeField("BDDOC", "BDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("BDK74PBST", "BDK74PBST", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7430051_0", "Primary Key on BDUKID, BDK74LECO, BDK74LEDT, BDK74ISPL, BDKCO, BDDCT, BDDOC", new[] { "BDUKID", "BDK74LECO", "BDK74LEDT", "BDK74ISPL", "BDKCO", "BDDCT", "BDDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
