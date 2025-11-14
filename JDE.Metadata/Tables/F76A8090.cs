using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8090 - .
/// </summary>
public class F76A8090 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VPCO.
        /// </summary>
        public const string VPCO = "VPCO";

        /// <summary>
        /// VPA002.
        /// </summary>
        public const string VPA002 = "VPA002";

        /// <summary>
        /// VPAVEN.
        /// </summary>
        public const string VPAVEN = "VPAVEN";

        /// <summary>
        /// VPRP1.
        /// </summary>
        public const string VPRP1 = "VPRP1";

        /// <summary>
        /// VPEFTJ.
        /// </summary>
        public const string VPEFTJ = "VPEFTJ";

        /// <summary>
        /// VPEFDJ.
        /// </summary>
        public const string VPEFDJ = "VPEFDJ";

        /// <summary>
        /// VPAPR1.
        /// </summary>
        public const string VPAPR1 = "VPAPR1";

        /// <summary>
        /// VPAIM.
        /// </summary>
        public const string VPAIM = "VPAIM";

        /// <summary>
        /// VPUSER.
        /// </summary>
        public const string VPUSER = "VPUSER";

        /// <summary>
        /// VPPID.
        /// </summary>
        public const string VPPID = "VPPID";

        /// <summary>
        /// VPUPMJ.
        /// </summary>
        public const string VPUPMJ = "VPUPMJ";

        /// <summary>
        /// VPUPMT.
        /// </summary>
        public const string VPUPMT = "VPUPMT";

        /// <summary>
        /// VPJOBN.
        /// </summary>
        public const string VPJOBN = "VPJOBN";

        /// <summary>
        /// VPURC1.
        /// </summary>
        public const string VPURC1 = "VPURC1";

        /// <summary>
        /// VPURDT.
        /// </summary>
        public const string VPURDT = "VPURDT";

        /// <summary>
        /// VPURAT.
        /// </summary>
        public const string VPURAT = "VPURAT";

        /// <summary>
        /// VPURAB.
        /// </summary>
        public const string VPURAB = "VPURAB";

        /// <summary>
        /// VPURRF.
        /// </summary>
        public const string VPURRF = "VPURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8090";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VPCO", "VPCO", JdeDataType.String, 10, true, true),
        new JdeField("VPA002", "VPA002", JdeDataType.String, 6, true, true),
        new JdeField("VPAVEN", "VPAVEN", JdeDataType.String, 2, true, true),
        new JdeField("VPRP1", "VPRP1", JdeDataType.String, 2, true, true),
        new JdeField("VPEFTJ", "VPEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("VPEFDJ", "VPEFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("VPAPR1", "VPAPR1", JdeDataType.Numeric),
        new JdeField("VPAIM", "VPAIM", JdeDataType.Numeric),
        new JdeField("VPUSER", "VPUSER", JdeDataType.String, 20),
        new JdeField("VPPID", "VPPID", JdeDataType.String, 20),
        new JdeField("VPUPMJ", "VPUPMJ", JdeDataType.Numeric),
        new JdeField("VPUPMT", "VPUPMT", JdeDataType.Numeric),
        new JdeField("VPJOBN", "VPJOBN", JdeDataType.String, 20),
        new JdeField("VPURC1", "VPURC1", JdeDataType.String, 6),
        new JdeField("VPURDT", "VPURDT", JdeDataType.Numeric),
        new JdeField("VPURAT", "VPURAT", JdeDataType.Numeric),
        new JdeField("VPURAB", "VPURAB", JdeDataType.Numeric),
        new JdeField("VPURRF", "VPURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8090_0", "Primary Key on VPCO, VPA002, VPAVEN, VPRP1, VPEFTJ, VPEFDJ", new[] { "VPCO", "VPA002", "VPAVEN", "VPRP1", "VPEFTJ", "VPEFDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
