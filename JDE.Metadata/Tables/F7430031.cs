using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7430031 - .
/// </summary>
public class F7430031 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PIKCO.
        /// </summary>
        public const string PIKCO = "PIKCO";

        /// <summary>
        /// PIDCT.
        /// </summary>
        public const string PIDCT = "PIDCT";

        /// <summary>
        /// PIDOC.
        /// </summary>
        public const string PIDOC = "PIDOC";

        /// <summary>
        /// PIAN8.
        /// </summary>
        public const string PIAN8 = "PIAN8";

        /// <summary>
        /// PIANTY.
        /// </summary>
        public const string PIANTY = "PIANTY";

        /// <summary>
        /// PIALPH.
        /// </summary>
        public const string PIALPH = "PIALPH";

        /// <summary>
        /// PIMLNM.
        /// </summary>
        public const string PIMLNM = "PIMLNM";

        /// <summary>
        /// PIADD1.
        /// </summary>
        public const string PIADD1 = "PIADD1";

        /// <summary>
        /// PIADD2.
        /// </summary>
        public const string PIADD2 = "PIADD2";

        /// <summary>
        /// PIADD3.
        /// </summary>
        public const string PIADD3 = "PIADD3";

        /// <summary>
        /// PIADD4.
        /// </summary>
        public const string PIADD4 = "PIADD4";

        /// <summary>
        /// PICTY1.
        /// </summary>
        public const string PICTY1 = "PICTY1";

        /// <summary>
        /// PICOUN.
        /// </summary>
        public const string PICOUN = "PICOUN";

        /// <summary>
        /// PIADDS.
        /// </summary>
        public const string PIADDS = "PIADDS";

        /// <summary>
        /// PIADDZ.
        /// </summary>
        public const string PIADDZ = "PIADDZ";

        /// <summary>
        /// PICTR.
        /// </summary>
        public const string PICTR = "PICTR";

        /// <summary>
        /// PIAR1.
        /// </summary>
        public const string PIAR1 = "PIAR1";

        /// <summary>
        /// PIPH1.
        /// </summary>
        public const string PIPH1 = "PIPH1";

        /// <summary>
        /// PITAX.
        /// </summary>
        public const string PITAX = "PITAX";

        /// <summary>
        /// PITX2.
        /// </summary>
        public const string PITX2 = "PITX2";
    }

    /// <inheritdoc />
    public override string TableName => "F7430031";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIKCO", "PIKCO", JdeDataType.String, 10, true, true),
        new JdeField("PIDCT", "PIDCT", JdeDataType.String, 4, true, true),
        new JdeField("PIDOC", "PIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PIAN8", "PIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PIANTY", "PIANTY", JdeDataType.String, 2, true, true),
        new JdeField("PIALPH", "PIALPH", JdeDataType.String, 80),
        new JdeField("PIMLNM", "PIMLNM", JdeDataType.String, 80),
        new JdeField("PIADD1", "PIADD1", JdeDataType.String, 80),
        new JdeField("PIADD2", "PIADD2", JdeDataType.String, 80),
        new JdeField("PIADD3", "PIADD3", JdeDataType.String, 80),
        new JdeField("PIADD4", "PIADD4", JdeDataType.String, 80),
        new JdeField("PICTY1", "PICTY1", JdeDataType.String, 50),
        new JdeField("PICOUN", "PICOUN", JdeDataType.String, 50),
        new JdeField("PIADDS", "PIADDS", JdeDataType.String, 6),
        new JdeField("PIADDZ", "PIADDZ", JdeDataType.String, 24),
        new JdeField("PICTR", "PICTR", JdeDataType.String, 6),
        new JdeField("PIAR1", "PIAR1", JdeDataType.String, 12),
        new JdeField("PIPH1", "PIPH1", JdeDataType.String, 40),
        new JdeField("PITAX", "PITAX", JdeDataType.String, 40),
        new JdeField("PITX2", "PITX2", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7430031_0", "Primary Key on PIKCO, PIDCT, PIDOC, PIAN8, PIANTY", new[] { "PIKCO", "PIDCT", "PIDOC", "PIAN8", "PIANTY" }, isUnique: true, isPrimaryKey: true)
    };
}
