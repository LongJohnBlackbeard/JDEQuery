using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F740002 - .
/// </summary>
public class F740002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// COCO.
        /// </summary>
        public const string COCO = "COCO";

        /// <summary>
        /// COK74SCHNM.
        /// </summary>
        public const string COK74SCHNM = "COK74SCHNM";

        /// <summary>
        /// COUSER.
        /// </summary>
        public const string COUSER = "COUSER";

        /// <summary>
        /// COPID.
        /// </summary>
        public const string COPID = "COPID";

        /// <summary>
        /// COJOBN.
        /// </summary>
        public const string COJOBN = "COJOBN";

        /// <summary>
        /// COUPMJ.
        /// </summary>
        public const string COUPMJ = "COUPMJ";

        /// <summary>
        /// COUPMT.
        /// </summary>
        public const string COUPMT = "COUPMT";

        /// <summary>
        /// COYFUTDT.
        /// </summary>
        public const string COYFUTDT = "COYFUTDT";

        /// <summary>
        /// COFUT3.
        /// </summary>
        public const string COFUT3 = "COFUT3";

        /// <summary>
        /// COFUTCH1.
        /// </summary>
        public const string COFUTCH1 = "COFUTCH1";

        /// <summary>
        /// COX2.
        /// </summary>
        public const string COX2 = "COX2";

        /// <summary>
        /// COFFU4.
        /// </summary>
        public const string COFFU4 = "COFFU4";
    }

    /// <inheritdoc />
    public override string TableName => "F740002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("COCO", "COCO", JdeDataType.String, 10, true, true),
        new JdeField("COK74SCHNM", "COK74SCHNM", JdeDataType.String, 20),
        new JdeField("COUSER", "COUSER", JdeDataType.String, 20),
        new JdeField("COPID", "COPID", JdeDataType.String, 20),
        new JdeField("COJOBN", "COJOBN", JdeDataType.String, 20),
        new JdeField("COUPMJ", "COUPMJ", JdeDataType.Numeric),
        new JdeField("COUPMT", "COUPMT", JdeDataType.Numeric),
        new JdeField("COYFUTDT", "COYFUTDT", JdeDataType.Numeric),
        new JdeField("COFUT3", "COFUT3", JdeDataType.String, 60),
        new JdeField("COFUTCH1", "COFUTCH1", JdeDataType.String, 2),
        new JdeField("COX2", "COX2", JdeDataType.String, 2),
        new JdeField("COFFU4", "COFFU4", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F740002_0", "Primary Key on COCO", new[] { "COCO" }, isUnique: true, isPrimaryKey: true)
    };
}
