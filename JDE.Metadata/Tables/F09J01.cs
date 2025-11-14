using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J01 - .
/// </summary>
public class F09J01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JEAID.
        /// </summary>
        public const string JEAID = "JEAID";

        /// <summary>
        /// JEJVDF.
        /// </summary>
        public const string JEJVDF = "JEJVDF";

        /// <summary>
        /// JETORG.
        /// </summary>
        public const string JETORG = "JETORG";

        /// <summary>
        /// JEENTJ.
        /// </summary>
        public const string JEENTJ = "JEENTJ";

        /// <summary>
        /// JEUSER.
        /// </summary>
        public const string JEUSER = "JEUSER";

        /// <summary>
        /// JEUPMJ.
        /// </summary>
        public const string JEUPMJ = "JEUPMJ";

        /// <summary>
        /// JEUPMT.
        /// </summary>
        public const string JEUPMT = "JEUPMT";

        /// <summary>
        /// JEPID.
        /// </summary>
        public const string JEPID = "JEPID";

        /// <summary>
        /// JEMKEY.
        /// </summary>
        public const string JEMKEY = "JEMKEY";

        /// <summary>
        /// JEURAB.
        /// </summary>
        public const string JEURAB = "JEURAB";

        /// <summary>
        /// JEURCD.
        /// </summary>
        public const string JEURCD = "JEURCD";

        /// <summary>
        /// JEURAT.
        /// </summary>
        public const string JEURAT = "JEURAT";

        /// <summary>
        /// JEURDT.
        /// </summary>
        public const string JEURDT = "JEURDT";

        /// <summary>
        /// JEURRF.
        /// </summary>
        public const string JEURRF = "JEURRF";

        /// <summary>
        /// JEJVANU1.
        /// </summary>
        public const string JEJVANU1 = "JEJVANU1";

        /// <summary>
        /// JEJVANU2.
        /// </summary>
        public const string JEJVANU2 = "JEJVANU2";

        /// <summary>
        /// JEJVANU3.
        /// </summary>
        public const string JEJVANU3 = "JEJVANU3";

        /// <summary>
        /// JEJVAST1.
        /// </summary>
        public const string JEJVAST1 = "JEJVAST1";

        /// <summary>
        /// JEJVAST2.
        /// </summary>
        public const string JEJVAST2 = "JEJVAST2";

        /// <summary>
        /// JEJVAST3.
        /// </summary>
        public const string JEJVAST3 = "JEJVAST3";

        /// <summary>
        /// JEJVACH1.
        /// </summary>
        public const string JEJVACH1 = "JEJVACH1";

        /// <summary>
        /// JEJVACH2.
        /// </summary>
        public const string JEJVACH2 = "JEJVACH2";

        /// <summary>
        /// JEJVACH3.
        /// </summary>
        public const string JEJVACH3 = "JEJVACH3";

        /// <summary>
        /// JEJVADT1.
        /// </summary>
        public const string JEJVADT1 = "JEJVADT1";

        /// <summary>
        /// JEJVADT2.
        /// </summary>
        public const string JEJVADT2 = "JEJVADT2";

        /// <summary>
        /// JEJVADT3.
        /// </summary>
        public const string JEJVADT3 = "JEJVADT3";
    }

    /// <inheritdoc />
    public override string TableName => "F09J01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JEAID", "JEAID", JdeDataType.String, 16, true, true),
        new JdeField("JEJVDF", "JEJVDF", JdeDataType.String, 2),
        new JdeField("JETORG", "JETORG", JdeDataType.String, 20),
        new JdeField("JEENTJ", "JEENTJ", JdeDataType.Numeric),
        new JdeField("JEUSER", "JEUSER", JdeDataType.String, 20),
        new JdeField("JEUPMJ", "JEUPMJ", JdeDataType.Numeric),
        new JdeField("JEUPMT", "JEUPMT", JdeDataType.Numeric),
        new JdeField("JEPID", "JEPID", JdeDataType.String, 20),
        new JdeField("JEMKEY", "JEMKEY", JdeDataType.String, 30),
        new JdeField("JEURAB", "JEURAB", JdeDataType.Numeric),
        new JdeField("JEURCD", "JEURCD", JdeDataType.String, 4),
        new JdeField("JEURAT", "JEURAT", JdeDataType.Numeric),
        new JdeField("JEURDT", "JEURDT", JdeDataType.Numeric),
        new JdeField("JEURRF", "JEURRF", JdeDataType.String, 30),
        new JdeField("JEJVANU1", "JEJVANU1", JdeDataType.Numeric),
        new JdeField("JEJVANU2", "JEJVANU2", JdeDataType.Numeric),
        new JdeField("JEJVANU3", "JEJVANU3", JdeDataType.Numeric),
        new JdeField("JEJVAST1", "JEJVAST1", JdeDataType.String, 160),
        new JdeField("JEJVAST2", "JEJVAST2", JdeDataType.String, 160),
        new JdeField("JEJVAST3", "JEJVAST3", JdeDataType.String, 160),
        new JdeField("JEJVACH1", "JEJVACH1", JdeDataType.String, 2),
        new JdeField("JEJVACH2", "JEJVACH2", JdeDataType.String, 2),
        new JdeField("JEJVACH3", "JEJVACH3", JdeDataType.String, 2),
        new JdeField("JEJVADT1", "JEJVADT1", JdeDataType.Numeric),
        new JdeField("JEJVADT2", "JEJVADT2", JdeDataType.Numeric),
        new JdeField("JEJVADT3", "JEJVADT3", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J01_0", "Primary Key on JEAID", new[] { "JEAID" }, isUnique: true, isPrimaryKey: true)
    };
}
