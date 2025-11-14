using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B035 - .
/// </summary>
public class F76B035 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JPB76JPID.
        /// </summary>
        public const string JPB76JPID = "JPB76JPID";

        /// <summary>
        /// JPB76SCID.
        /// </summary>
        public const string JPB76SCID = "JPB76SCID";

        /// <summary>
        /// JPB76VRID.
        /// </summary>
        public const string JPB76VRID = "JPB76VRID";

        /// <summary>
        /// JPB76JNI.
        /// </summary>
        public const string JPB76JNI = "JPB76JNI";

        /// <summary>
        /// JPB76POI.
        /// </summary>
        public const string JPB76POI = "JPB76POI";

        /// <summary>
        /// JPB76TEDSC.
        /// </summary>
        public const string JPB76TEDSC = "JPB76TEDSC";

        /// <summary>
        /// JPB76JDGD.
        /// </summary>
        public const string JPB76JDGD = "JPB76JDGD";

        /// <summary>
        /// JPB76URAB.
        /// </summary>
        public const string JPB76URAB = "JPB76URAB";

        /// <summary>
        /// JPB76URAT.
        /// </summary>
        public const string JPB76URAT = "JPB76URAT";

        /// <summary>
        /// JPB76URRF.
        /// </summary>
        public const string JPB76URRF = "JPB76URRF";

        /// <summary>
        /// JPB76URDT.
        /// </summary>
        public const string JPB76URDT = "JPB76URDT";

        /// <summary>
        /// JPB76URCD.
        /// </summary>
        public const string JPB76URCD = "JPB76URCD";

        /// <summary>
        /// JPUSER.
        /// </summary>
        public const string JPUSER = "JPUSER";

        /// <summary>
        /// JPPID.
        /// </summary>
        public const string JPPID = "JPPID";

        /// <summary>
        /// JPJOBN.
        /// </summary>
        public const string JPJOBN = "JPJOBN";

        /// <summary>
        /// JPUPMJ.
        /// </summary>
        public const string JPUPMJ = "JPUPMJ";

        /// <summary>
        /// JPUPMT.
        /// </summary>
        public const string JPUPMT = "JPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B035";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JPB76JPID", "JPB76JPID", JdeDataType.String, 80, true, true),
        new JdeField("JPB76SCID", "JPB76SCID", JdeDataType.String, 512, true, true),
        new JdeField("JPB76VRID", "JPB76VRID", JdeDataType.String, 4, true, true),
        new JdeField("JPB76JNI", "JPB76JNI", JdeDataType.String, 4),
        new JdeField("JPB76POI", "JPB76POI", JdeDataType.Numeric),
        new JdeField("JPB76TEDSC", "JPB76TEDSC", JdeDataType.String, 200),
        new JdeField("JPB76JDGD", "JPB76JDGD", JdeDataType.Numeric),
        new JdeField("JPB76URAB", "JPB76URAB", JdeDataType.Numeric),
        new JdeField("JPB76URAT", "JPB76URAT", JdeDataType.Numeric),
        new JdeField("JPB76URRF", "JPB76URRF", JdeDataType.String, 30),
        new JdeField("JPB76URDT", "JPB76URDT", JdeDataType.Numeric),
        new JdeField("JPB76URCD", "JPB76URCD", JdeDataType.String, 4),
        new JdeField("JPUSER", "JPUSER", JdeDataType.String, 20),
        new JdeField("JPPID", "JPPID", JdeDataType.String, 20),
        new JdeField("JPJOBN", "JPJOBN", JdeDataType.String, 20),
        new JdeField("JPUPMJ", "JPUPMJ", JdeDataType.Numeric),
        new JdeField("JPUPMT", "JPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B035_0", "Primary Key on JPB76JPID, JPB76SCID, JPB76VRID", new[] { "JPB76JPID", "JPB76SCID", "JPB76VRID" }, isUnique: true, isPrimaryKey: true)
    };
}
