using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS04 - .
/// </summary>
public class F54HS04 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S5HSINO.
        /// </summary>
        public const string S5HSINO = "S5HSINO";

        /// <summary>
        /// S5UKID.
        /// </summary>
        public const string S5UKID = "S5UKID";

        /// <summary>
        /// S5HSIAN.
        /// </summary>
        public const string S5HSIAN = "S5HSIAN";

        /// <summary>
        /// S5HSIAD.
        /// </summary>
        public const string S5HSIAD = "S5HSIAD";

        /// <summary>
        /// S5HSIACN.
        /// </summary>
        public const string S5HSIACN = "S5HSIACN";

        /// <summary>
        /// S5AR1.
        /// </summary>
        public const string S5AR1 = "S5AR1";

        /// <summary>
        /// S5PH1.
        /// </summary>
        public const string S5PH1 = "S5PH1";

        /// <summary>
        /// S5HSIACE.
        /// </summary>
        public const string S5HSIACE = "S5HSIACE";

        /// <summary>
        /// S5VR01.
        /// </summary>
        public const string S5VR01 = "S5VR01";

        /// <summary>
        /// S5HSIAC.
        /// </summary>
        public const string S5HSIAC = "S5HSIAC";

        /// <summary>
        /// S5URAB.
        /// </summary>
        public const string S5URAB = "S5URAB";

        /// <summary>
        /// S5URCD.
        /// </summary>
        public const string S5URCD = "S5URCD";

        /// <summary>
        /// S5URAT.
        /// </summary>
        public const string S5URAT = "S5URAT";

        /// <summary>
        /// S5URDT.
        /// </summary>
        public const string S5URDT = "S5URDT";

        /// <summary>
        /// S5URRF.
        /// </summary>
        public const string S5URRF = "S5URRF";

        /// <summary>
        /// S5USER.
        /// </summary>
        public const string S5USER = "S5USER";

        /// <summary>
        /// S5UPMJ.
        /// </summary>
        public const string S5UPMJ = "S5UPMJ";

        /// <summary>
        /// S5UPMT.
        /// </summary>
        public const string S5UPMT = "S5UPMT";

        /// <summary>
        /// S5JOBN.
        /// </summary>
        public const string S5JOBN = "S5JOBN";

        /// <summary>
        /// S5PID.
        /// </summary>
        public const string S5PID = "S5PID";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS04";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S5HSINO", "S5HSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("S5UKID", "S5UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("S5HSIAN", "S5HSIAN", JdeDataType.Numeric),
        new JdeField("S5HSIAD", "S5HSIAD", JdeDataType.String, 80),
        new JdeField("S5HSIACN", "S5HSIACN", JdeDataType.String, 80),
        new JdeField("S5AR1", "S5AR1", JdeDataType.String, 12),
        new JdeField("S5PH1", "S5PH1", JdeDataType.String, 40),
        new JdeField("S5HSIACE", "S5HSIACE", JdeDataType.String, 150),
        new JdeField("S5VR01", "S5VR01", JdeDataType.String, 50),
        new JdeField("S5HSIAC", "S5HSIAC", JdeDataType.String, 100),
        new JdeField("S5URAB", "S5URAB", JdeDataType.Numeric),
        new JdeField("S5URCD", "S5URCD", JdeDataType.String, 4),
        new JdeField("S5URAT", "S5URAT", JdeDataType.Numeric),
        new JdeField("S5URDT", "S5URDT", JdeDataType.Numeric),
        new JdeField("S5URRF", "S5URRF", JdeDataType.String, 30),
        new JdeField("S5USER", "S5USER", JdeDataType.String, 20),
        new JdeField("S5UPMJ", "S5UPMJ", JdeDataType.Numeric),
        new JdeField("S5UPMT", "S5UPMT", JdeDataType.Numeric),
        new JdeField("S5JOBN", "S5JOBN", JdeDataType.String, 20),
        new JdeField("S5PID", "S5PID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS04_0", "Primary Key on S5HSINO, S5UKID", new[] { "S5HSINO", "S5UKID" }, isUnique: true, isPrimaryKey: true)
    };
}
