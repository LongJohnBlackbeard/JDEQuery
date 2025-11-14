using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS021 - .
/// </summary>
public class F54HS021 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S3HSINO.
        /// </summary>
        public const string S3HSINO = "S3HSINO";

        /// <summary>
        /// S3UK01.
        /// </summary>
        public const string S3UK01 = "S3UK01";

        /// <summary>
        /// S3UKID.
        /// </summary>
        public const string S3UKID = "S3UKID";

        /// <summary>
        /// S3AN8.
        /// </summary>
        public const string S3AN8 = "S3AN8";

        /// <summary>
        /// S3DL01.
        /// </summary>
        public const string S3DL01 = "S3DL01";

        /// <summary>
        /// S3HSINI.
        /// </summary>
        public const string S3HSINI = "S3HSINI";

        /// <summary>
        /// S3HSIID.
        /// </summary>
        public const string S3HSIID = "S3HSIID";

        /// <summary>
        /// S3HSIPD.
        /// </summary>
        public const string S3HSIPD = "S3HSIPD";

        /// <summary>
        /// S3HSISI.
        /// </summary>
        public const string S3HSISI = "S3HSISI";

        /// <summary>
        /// S3HSIBP.
        /// </summary>
        public const string S3HSIBP = "S3HSIBP";

        /// <summary>
        /// S3HSISB.
        /// </summary>
        public const string S3HSISB = "S3HSISB";

        /// <summary>
        /// S3HSIEV.
        /// </summary>
        public const string S3HSIEV = "S3HSIEV";

        /// <summary>
        /// S3HSIIS.
        /// </summary>
        public const string S3HSIIS = "S3HSIIS";

        /// <summary>
        /// S3HSICS.
        /// </summary>
        public const string S3HSICS = "S3HSICS";

        /// <summary>
        /// S3HSII1.
        /// </summary>
        public const string S3HSII1 = "S3HSII1";

        /// <summary>
        /// S3HSII2.
        /// </summary>
        public const string S3HSII2 = "S3HSII2";

        /// <summary>
        /// S3HSII3.
        /// </summary>
        public const string S3HSII3 = "S3HSII3";

        /// <summary>
        /// S3HSII4.
        /// </summary>
        public const string S3HSII4 = "S3HSII4";

        /// <summary>
        /// S3HSII5.
        /// </summary>
        public const string S3HSII5 = "S3HSII5";

        /// <summary>
        /// S3URAB.
        /// </summary>
        public const string S3URAB = "S3URAB";

        /// <summary>
        /// S3URCD.
        /// </summary>
        public const string S3URCD = "S3URCD";

        /// <summary>
        /// S3URAT.
        /// </summary>
        public const string S3URAT = "S3URAT";

        /// <summary>
        /// S3URDT.
        /// </summary>
        public const string S3URDT = "S3URDT";

        /// <summary>
        /// S3URRF.
        /// </summary>
        public const string S3URRF = "S3URRF";

        /// <summary>
        /// S3USER.
        /// </summary>
        public const string S3USER = "S3USER";

        /// <summary>
        /// S3UPMJ.
        /// </summary>
        public const string S3UPMJ = "S3UPMJ";

        /// <summary>
        /// S3UPMT.
        /// </summary>
        public const string S3UPMT = "S3UPMT";

        /// <summary>
        /// S3JOBN.
        /// </summary>
        public const string S3JOBN = "S3JOBN";

        /// <summary>
        /// S3PID.
        /// </summary>
        public const string S3PID = "S3PID";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS021";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S3HSINO", "S3HSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("S3UK01", "S3UK01", JdeDataType.Numeric, null, true, true),
        new JdeField("S3UKID", "S3UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("S3AN8", "S3AN8", JdeDataType.Numeric),
        new JdeField("S3DL01", "S3DL01", JdeDataType.String, 60),
        new JdeField("S3HSINI", "S3HSINI", JdeDataType.String, 8),
        new JdeField("S3HSIID", "S3HSIID", JdeDataType.String, 80),
        new JdeField("S3HSIPD", "S3HSIPD", JdeDataType.String, 80),
        new JdeField("S3HSISI", "S3HSISI", JdeDataType.String, 4),
        new JdeField("S3HSIBP", "S3HSIBP", JdeDataType.String, 8),
        new JdeField("S3HSISB", "S3HSISB", JdeDataType.String, 4),
        new JdeField("S3HSIEV", "S3HSIEV", JdeDataType.String, 8),
        new JdeField("S3HSIIS", "S3HSIIS", JdeDataType.String, 8),
        new JdeField("S3HSICS", "S3HSICS", JdeDataType.String, 4),
        new JdeField("S3HSII1", "S3HSII1", JdeDataType.String, 6),
        new JdeField("S3HSII2", "S3HSII2", JdeDataType.String, 6),
        new JdeField("S3HSII3", "S3HSII3", JdeDataType.String, 6),
        new JdeField("S3HSII4", "S3HSII4", JdeDataType.String, 6),
        new JdeField("S3HSII5", "S3HSII5", JdeDataType.String, 6),
        new JdeField("S3URAB", "S3URAB", JdeDataType.Numeric),
        new JdeField("S3URCD", "S3URCD", JdeDataType.String, 4),
        new JdeField("S3URAT", "S3URAT", JdeDataType.Numeric),
        new JdeField("S3URDT", "S3URDT", JdeDataType.Numeric),
        new JdeField("S3URRF", "S3URRF", JdeDataType.String, 30),
        new JdeField("S3USER", "S3USER", JdeDataType.String, 20),
        new JdeField("S3UPMJ", "S3UPMJ", JdeDataType.Numeric),
        new JdeField("S3UPMT", "S3UPMT", JdeDataType.Numeric),
        new JdeField("S3JOBN", "S3JOBN", JdeDataType.String, 20),
        new JdeField("S3PID", "S3PID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS021_0", "Primary Key on S3HSINO, S3UK01, S3UKID", new[] { "S3HSINO", "S3UK01", "S3UKID" }, isUnique: true, isPrimaryKey: true)
    };
}
