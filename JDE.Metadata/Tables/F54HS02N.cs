using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS02N - .
/// </summary>
public class F54HS02N : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// I3HSINO.
        /// </summary>
        public const string I3HSINO = "I3HSINO";

        /// <summary>
        /// I3UK01.
        /// </summary>
        public const string I3UK01 = "I3UK01";

        /// <summary>
        /// I3UKID.
        /// </summary>
        public const string I3UKID = "I3UKID";

        /// <summary>
        /// I3HSIMN.
        /// </summary>
        public const string I3HSIMN = "I3HSIMN";

        /// <summary>
        /// I3HSIMT.
        /// </summary>
        public const string I3HSIMT = "I3HSIMT";

        /// <summary>
        /// I3MODDT.
        /// </summary>
        public const string I3MODDT = "I3MODDT";

        /// <summary>
        /// I3AN8.
        /// </summary>
        public const string I3AN8 = "I3AN8";

        /// <summary>
        /// I3DL01.
        /// </summary>
        public const string I3DL01 = "I3DL01";

        /// <summary>
        /// I3HSINI.
        /// </summary>
        public const string I3HSINI = "I3HSINI";

        /// <summary>
        /// I3HSIID.
        /// </summary>
        public const string I3HSIID = "I3HSIID";

        /// <summary>
        /// I3HSIPD.
        /// </summary>
        public const string I3HSIPD = "I3HSIPD";

        /// <summary>
        /// I3HSISI.
        /// </summary>
        public const string I3HSISI = "I3HSISI";

        /// <summary>
        /// I3HSIBP.
        /// </summary>
        public const string I3HSIBP = "I3HSIBP";

        /// <summary>
        /// I3HSISB.
        /// </summary>
        public const string I3HSISB = "I3HSISB";

        /// <summary>
        /// I3HSIEV.
        /// </summary>
        public const string I3HSIEV = "I3HSIEV";

        /// <summary>
        /// I3HSIIS.
        /// </summary>
        public const string I3HSIIS = "I3HSIIS";

        /// <summary>
        /// I3HSICS.
        /// </summary>
        public const string I3HSICS = "I3HSICS";

        /// <summary>
        /// I3HSII1.
        /// </summary>
        public const string I3HSII1 = "I3HSII1";

        /// <summary>
        /// I3HSII2.
        /// </summary>
        public const string I3HSII2 = "I3HSII2";

        /// <summary>
        /// I3HSII3.
        /// </summary>
        public const string I3HSII3 = "I3HSII3";

        /// <summary>
        /// I3HSII4.
        /// </summary>
        public const string I3HSII4 = "I3HSII4";

        /// <summary>
        /// I3HSII5.
        /// </summary>
        public const string I3HSII5 = "I3HSII5";

        /// <summary>
        /// I3URAB.
        /// </summary>
        public const string I3URAB = "I3URAB";

        /// <summary>
        /// I3URCD.
        /// </summary>
        public const string I3URCD = "I3URCD";

        /// <summary>
        /// I3URAT.
        /// </summary>
        public const string I3URAT = "I3URAT";

        /// <summary>
        /// I3URDT.
        /// </summary>
        public const string I3URDT = "I3URDT";

        /// <summary>
        /// I3URRF.
        /// </summary>
        public const string I3URRF = "I3URRF";

        /// <summary>
        /// I3USER.
        /// </summary>
        public const string I3USER = "I3USER";

        /// <summary>
        /// I3UPMJ.
        /// </summary>
        public const string I3UPMJ = "I3UPMJ";

        /// <summary>
        /// I3UPMT.
        /// </summary>
        public const string I3UPMT = "I3UPMT";

        /// <summary>
        /// I3JOBN.
        /// </summary>
        public const string I3JOBN = "I3JOBN";

        /// <summary>
        /// I3PID.
        /// </summary>
        public const string I3PID = "I3PID";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS02N";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("I3HSINO", "I3HSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("I3UK01", "I3UK01", JdeDataType.Numeric, null, true, true),
        new JdeField("I3UKID", "I3UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("I3HSIMN", "I3HSIMN", JdeDataType.Numeric, null, true, true),
        new JdeField("I3HSIMT", "I3HSIMT", JdeDataType.String, 2),
        new JdeField("I3MODDT", "I3MODDT", JdeDataType.Numeric),
        new JdeField("I3AN8", "I3AN8", JdeDataType.Numeric),
        new JdeField("I3DL01", "I3DL01", JdeDataType.String, 60),
        new JdeField("I3HSINI", "I3HSINI", JdeDataType.String, 8),
        new JdeField("I3HSIID", "I3HSIID", JdeDataType.String, 80),
        new JdeField("I3HSIPD", "I3HSIPD", JdeDataType.String, 80),
        new JdeField("I3HSISI", "I3HSISI", JdeDataType.String, 4),
        new JdeField("I3HSIBP", "I3HSIBP", JdeDataType.String, 8),
        new JdeField("I3HSISB", "I3HSISB", JdeDataType.String, 4),
        new JdeField("I3HSIEV", "I3HSIEV", JdeDataType.String, 8),
        new JdeField("I3HSIIS", "I3HSIIS", JdeDataType.String, 8),
        new JdeField("I3HSICS", "I3HSICS", JdeDataType.String, 4),
        new JdeField("I3HSII1", "I3HSII1", JdeDataType.String, 6),
        new JdeField("I3HSII2", "I3HSII2", JdeDataType.String, 6),
        new JdeField("I3HSII3", "I3HSII3", JdeDataType.String, 6),
        new JdeField("I3HSII4", "I3HSII4", JdeDataType.String, 6),
        new JdeField("I3HSII5", "I3HSII5", JdeDataType.String, 6),
        new JdeField("I3URAB", "I3URAB", JdeDataType.Numeric),
        new JdeField("I3URCD", "I3URCD", JdeDataType.String, 4),
        new JdeField("I3URAT", "I3URAT", JdeDataType.Numeric),
        new JdeField("I3URDT", "I3URDT", JdeDataType.Numeric),
        new JdeField("I3URRF", "I3URRF", JdeDataType.String, 30),
        new JdeField("I3USER", "I3USER", JdeDataType.String, 20),
        new JdeField("I3UPMJ", "I3UPMJ", JdeDataType.Numeric),
        new JdeField("I3UPMT", "I3UPMT", JdeDataType.Numeric),
        new JdeField("I3JOBN", "I3JOBN", JdeDataType.String, 20),
        new JdeField("I3PID", "I3PID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS02N_0", "Primary Key on I3HSINO, I3UK01, I3UKID, I3HSIMN", new[] { "I3HSINO", "I3UK01", "I3UKID", "I3HSIMN" }, isUnique: true, isPrimaryKey: true)
    };
}
