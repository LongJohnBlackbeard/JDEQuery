using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS04M - .
/// </summary>
public class F54HS04M : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// I5HSINO.
        /// </summary>
        public const string I5HSINO = "I5HSINO";

        /// <summary>
        /// I5UKID.
        /// </summary>
        public const string I5UKID = "I5UKID";

        /// <summary>
        /// I5HSIMN.
        /// </summary>
        public const string I5HSIMN = "I5HSIMN";

        /// <summary>
        /// I5HSIMT.
        /// </summary>
        public const string I5HSIMT = "I5HSIMT";

        /// <summary>
        /// I5MODDT.
        /// </summary>
        public const string I5MODDT = "I5MODDT";

        /// <summary>
        /// I5HSIAN.
        /// </summary>
        public const string I5HSIAN = "I5HSIAN";

        /// <summary>
        /// I5HSIAD.
        /// </summary>
        public const string I5HSIAD = "I5HSIAD";

        /// <summary>
        /// I5HSIACN.
        /// </summary>
        public const string I5HSIACN = "I5HSIACN";

        /// <summary>
        /// I5AR1.
        /// </summary>
        public const string I5AR1 = "I5AR1";

        /// <summary>
        /// I5PH1.
        /// </summary>
        public const string I5PH1 = "I5PH1";

        /// <summary>
        /// I5HSIACE.
        /// </summary>
        public const string I5HSIACE = "I5HSIACE";

        /// <summary>
        /// I5VR01.
        /// </summary>
        public const string I5VR01 = "I5VR01";

        /// <summary>
        /// I5HSIAC.
        /// </summary>
        public const string I5HSIAC = "I5HSIAC";

        /// <summary>
        /// I5URAB.
        /// </summary>
        public const string I5URAB = "I5URAB";

        /// <summary>
        /// I5URCD.
        /// </summary>
        public const string I5URCD = "I5URCD";

        /// <summary>
        /// I5URAT.
        /// </summary>
        public const string I5URAT = "I5URAT";

        /// <summary>
        /// I5URDT.
        /// </summary>
        public const string I5URDT = "I5URDT";

        /// <summary>
        /// I5URRF.
        /// </summary>
        public const string I5URRF = "I5URRF";

        /// <summary>
        /// I5USER.
        /// </summary>
        public const string I5USER = "I5USER";

        /// <summary>
        /// I5UPMJ.
        /// </summary>
        public const string I5UPMJ = "I5UPMJ";

        /// <summary>
        /// I5UPMT.
        /// </summary>
        public const string I5UPMT = "I5UPMT";

        /// <summary>
        /// I5JOBN.
        /// </summary>
        public const string I5JOBN = "I5JOBN";

        /// <summary>
        /// I5PID.
        /// </summary>
        public const string I5PID = "I5PID";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS04M";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("I5HSINO", "I5HSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("I5UKID", "I5UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("I5HSIMN", "I5HSIMN", JdeDataType.Numeric, null, true, true),
        new JdeField("I5HSIMT", "I5HSIMT", JdeDataType.String, 2),
        new JdeField("I5MODDT", "I5MODDT", JdeDataType.Numeric),
        new JdeField("I5HSIAN", "I5HSIAN", JdeDataType.Numeric),
        new JdeField("I5HSIAD", "I5HSIAD", JdeDataType.String, 80),
        new JdeField("I5HSIACN", "I5HSIACN", JdeDataType.String, 80),
        new JdeField("I5AR1", "I5AR1", JdeDataType.String, 12),
        new JdeField("I5PH1", "I5PH1", JdeDataType.String, 40),
        new JdeField("I5HSIACE", "I5HSIACE", JdeDataType.String, 150),
        new JdeField("I5VR01", "I5VR01", JdeDataType.String, 50),
        new JdeField("I5HSIAC", "I5HSIAC", JdeDataType.String, 100),
        new JdeField("I5URAB", "I5URAB", JdeDataType.Numeric),
        new JdeField("I5URCD", "I5URCD", JdeDataType.String, 4),
        new JdeField("I5URAT", "I5URAT", JdeDataType.Numeric),
        new JdeField("I5URDT", "I5URDT", JdeDataType.Numeric),
        new JdeField("I5URRF", "I5URRF", JdeDataType.String, 30),
        new JdeField("I5USER", "I5USER", JdeDataType.String, 20),
        new JdeField("I5UPMJ", "I5UPMJ", JdeDataType.Numeric),
        new JdeField("I5UPMT", "I5UPMT", JdeDataType.Numeric),
        new JdeField("I5JOBN", "I5JOBN", JdeDataType.String, 20),
        new JdeField("I5PID", "I5PID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS04M_0", "Primary Key on I5HSINO, I5UKID, I5HSIMN", new[] { "I5HSINO", "I5UKID", "I5HSIMN" }, isUnique: true, isPrimaryKey: true)
    };
}
