using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08390 - .
/// </summary>
public class F08390 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// B9XET.
        /// </summary>
        public const string B9XET = "B9XET";

        /// <summary>
        /// B9DL01.
        /// </summary>
        public const string B9DL01 = "B9DL01";

        /// <summary>
        /// B9LIN.
        /// </summary>
        public const string B9LIN = "B9LIN";

        /// <summary>
        /// B9MTHD.
        /// </summary>
        public const string B9MTHD = "B9MTHD";

        /// <summary>
        /// B9ELMH.
        /// </summary>
        public const string B9ELMH = "B9ELMH";

        /// <summary>
        /// B9BSDF.
        /// </summary>
        public const string B9BSDF = "B9BSDF";

        /// <summary>
        /// B9ECP1.
        /// </summary>
        public const string B9ECP1 = "B9ECP1";

        /// <summary>
        /// B9NPRD.
        /// </summary>
        public const string B9NPRD = "B9NPRD";

        /// <summary>
        /// B9PTEH.
        /// </summary>
        public const string B9PTEH = "B9PTEH";

        /// <summary>
        /// B9AOR1.
        /// </summary>
        public const string B9AOR1 = "B9AOR1";

        /// <summary>
        /// B9STSE.
        /// </summary>
        public const string B9STSE = "B9STSE";

        /// <summary>
        /// B9STSI.
        /// </summary>
        public const string B9STSI = "B9STSI";

        /// <summary>
        /// B9ENCD.
        /// </summary>
        public const string B9ENCD = "B9ENCD";

        /// <summary>
        /// B9TMCD.
        /// </summary>
        public const string B9TMCD = "B9TMCD";

        /// <summary>
        /// B9PRG1.
        /// </summary>
        public const string B9PRG1 = "B9PRG1";

        /// <summary>
        /// B9PRG2.
        /// </summary>
        public const string B9PRG2 = "B9PRG2";
    }

    /// <inheritdoc />
    public override string TableName => "F08390";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("B9XET", "B9XET", JdeDataType.String, 8, true, true),
        new JdeField("B9DL01", "B9DL01", JdeDataType.String, 60),
        new JdeField("B9LIN", "B9LIN", JdeDataType.Numeric, null, true, true),
        new JdeField("B9MTHD", "B9MTHD", JdeDataType.String, 4),
        new JdeField("B9ELMH", "B9ELMH", JdeDataType.Numeric),
        new JdeField("B9BSDF", "B9BSDF", JdeDataType.String, 8),
        new JdeField("B9ECP1", "B9ECP1", JdeDataType.String, 2),
        new JdeField("B9NPRD", "B9NPRD", JdeDataType.Numeric),
        new JdeField("B9PTEH", "B9PTEH", JdeDataType.String, 8),
        new JdeField("B9AOR1", "B9AOR1", JdeDataType.String, 6),
        new JdeField("B9STSE", "B9STSE", JdeDataType.String, 6),
        new JdeField("B9STSI", "B9STSI", JdeDataType.String, 6),
        new JdeField("B9ENCD", "B9ENCD", JdeDataType.String, 4),
        new JdeField("B9TMCD", "B9TMCD", JdeDataType.String, 4),
        new JdeField("B9PRG1", "B9PRG1", JdeDataType.String, 20),
        new JdeField("B9PRG2", "B9PRG2", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08390_0", "Primary Key on B9XET, B9LIN", new[] { "B9XET", "B9LIN" }, isUnique: true, isPrimaryKey: true)
    };
}
