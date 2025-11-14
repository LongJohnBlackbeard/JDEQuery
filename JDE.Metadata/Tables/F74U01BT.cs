using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U01BT - .
/// </summary>
public class F74U01BT : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P3DOCO.
        /// </summary>
        public const string P3DOCO = "P3DOCO";

        /// <summary>
        /// P3LSVR.
        /// </summary>
        public const string P3LSVR = "P3LSVR";

        /// <summary>
        /// P3MCU.
        /// </summary>
        public const string P3MCU = "P3MCU";

        /// <summary>
        /// P3UNIT.
        /// </summary>
        public const string P3UNIT = "P3UNIT";

        /// <summary>
        /// P374UBKCD.
        /// </summary>
        public const string P374UBKCD = "P374UBKCD";

        /// <summary>
        /// P374UOBR.
        /// </summary>
        public const string P374UOBR = "P374UOBR";

        /// <summary>
        /// P374UEFTB.
        /// </summary>
        public const string P374UEFTB = "P374UEFTB";

        /// <summary>
        /// P374UEFTE.
        /// </summary>
        public const string P374UEFTE = "P374UEFTE";

        /// <summary>
        /// P374UNYC.
        /// </summary>
        public const string P374UNYC = "P374UNYC";

        /// <summary>
        /// P374UNYA.
        /// </summary>
        public const string P374UNYA = "P374UNYA";

        /// <summary>
        /// P374ULYR.
        /// </summary>
        public const string P374ULYR = "P374ULYR";

        /// <summary>
        /// P374UCRCD.
        /// </summary>
        public const string P374UCRCD = "P374UCRCD";

        /// <summary>
        /// P374UCRCA.
        /// </summary>
        public const string P374UCRCA = "P374UCRCA";

        /// <summary>
        /// P374UEXR.
        /// </summary>
        public const string P374UEXR = "P374UEXR";

        /// <summary>
        /// P374UEFTJ.
        /// </summary>
        public const string P374UEFTJ = "P374UEFTJ";

        /// <summary>
        /// P374USEQN.
        /// </summary>
        public const string P374USEQN = "P374USEQN";

        /// <summary>
        /// P374UEUF.
        /// </summary>
        public const string P374UEUF = "P374UEUF";

        /// <summary>
        /// P374UUD1.
        /// </summary>
        public const string P374UUD1 = "P374UUD1";

        /// <summary>
        /// P374UUD2.
        /// </summary>
        public const string P374UUD2 = "P374UUD2";

        /// <summary>
        /// P3URCD.
        /// </summary>
        public const string P3URCD = "P3URCD";

        /// <summary>
        /// P3URDT.
        /// </summary>
        public const string P3URDT = "P3URDT";

        /// <summary>
        /// P3URAT.
        /// </summary>
        public const string P3URAT = "P3URAT";

        /// <summary>
        /// P3URAB.
        /// </summary>
        public const string P3URAB = "P3URAB";

        /// <summary>
        /// P3URRF.
        /// </summary>
        public const string P3URRF = "P3URRF";

        /// <summary>
        /// P3USER.
        /// </summary>
        public const string P3USER = "P3USER";

        /// <summary>
        /// P3PID.
        /// </summary>
        public const string P3PID = "P3PID";

        /// <summary>
        /// P3UPMJ.
        /// </summary>
        public const string P3UPMJ = "P3UPMJ";

        /// <summary>
        /// P3UPMT.
        /// </summary>
        public const string P3UPMT = "P3UPMT";

        /// <summary>
        /// P3JOBN.
        /// </summary>
        public const string P3JOBN = "P3JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U01BT";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P3DOCO", "P3DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("P3LSVR", "P3LSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("P3MCU", "P3MCU", JdeDataType.String, 24),
        new JdeField("P3UNIT", "P3UNIT", JdeDataType.String, 16),
        new JdeField("P374UBKCD", "P374UBKCD", JdeDataType.String, 6),
        new JdeField("P374UOBR", "P374UOBR", JdeDataType.Numeric),
        new JdeField("P374UEFTB", "P374UEFTB", JdeDataType.Numeric),
        new JdeField("P374UEFTE", "P374UEFTE", JdeDataType.Numeric),
        new JdeField("P374UNYC", "P374UNYC", JdeDataType.Numeric),
        new JdeField("P374UNYA", "P374UNYA", JdeDataType.Numeric),
        new JdeField("P374ULYR", "P374ULYR", JdeDataType.String, 2),
        new JdeField("P374UCRCD", "P374UCRCD", JdeDataType.String, 6),
        new JdeField("P374UCRCA", "P374UCRCA", JdeDataType.String, 6),
        new JdeField("P374UEXR", "P374UEXR", JdeDataType.Numeric),
        new JdeField("P374UEFTJ", "P374UEFTJ", JdeDataType.Numeric),
        new JdeField("P374USEQN", "P374USEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("P374UEUF", "P374UEUF", JdeDataType.String, 2),
        new JdeField("P374UUD1", "P374UUD1", JdeDataType.String, 2),
        new JdeField("P374UUD2", "P374UUD2", JdeDataType.String, 2),
        new JdeField("P3URCD", "P3URCD", JdeDataType.String, 4),
        new JdeField("P3URDT", "P3URDT", JdeDataType.Numeric),
        new JdeField("P3URAT", "P3URAT", JdeDataType.Numeric),
        new JdeField("P3URAB", "P3URAB", JdeDataType.Numeric),
        new JdeField("P3URRF", "P3URRF", JdeDataType.String, 30),
        new JdeField("P3USER", "P3USER", JdeDataType.String, 20),
        new JdeField("P3PID", "P3PID", JdeDataType.String, 20),
        new JdeField("P3UPMJ", "P3UPMJ", JdeDataType.Numeric),
        new JdeField("P3UPMT", "P3UPMT", JdeDataType.Numeric),
        new JdeField("P3JOBN", "P3JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U01BT_0", "Primary Key on P3DOCO, P3LSVR, P374USEQN", new[] { "P3DOCO", "P3LSVR", "P374USEQN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U01BT_3", "Index on P3DOCO, P3LSVR, P374UEUF, P374USEQN", new[] { "P3DOCO", "P3LSVR", "P374UEUF", "P374USEQN" }),
        new JdeIndex("F74U01BT_4", "Index on P3DOCO, P3LSVR, P374UEFTB, P374UBKCD", new[] { "P3DOCO", "P3LSVR", "P374UEFTB", "P374UBKCD" })
    };
}
