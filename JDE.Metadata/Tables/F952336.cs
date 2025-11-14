using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F952336 - .
/// </summary>
public class F952336 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHPUBLISTID.
        /// </summary>
        public const string PHPUBLISTID = "PHPUBLISTID";

        /// <summary>
        /// PHPUBLISTDES.
        /// </summary>
        public const string PHPUBLISTDES = "PHPUBLISTDES";

        /// <summary>
        /// PHPUBFU1.
        /// </summary>
        public const string PHPUBFU1 = "PHPUBFU1";

        /// <summary>
        /// PHPUBFU2.
        /// </summary>
        public const string PHPUBFU2 = "PHPUBFU2";

        /// <summary>
        /// PHPUBFU3.
        /// </summary>
        public const string PHPUBFU3 = "PHPUBFU3";

        /// <summary>
        /// PHPUBFU4.
        /// </summary>
        public const string PHPUBFU4 = "PHPUBFU4";

        /// <summary>
        /// PHPUBFU5.
        /// </summary>
        public const string PHPUBFU5 = "PHPUBFU5";

        /// <summary>
        /// PHPUBFU6.
        /// </summary>
        public const string PHPUBFU6 = "PHPUBFU6";

        /// <summary>
        /// PHPUBFU7.
        /// </summary>
        public const string PHPUBFU7 = "PHPUBFU7";

        /// <summary>
        /// PHPUBFU8.
        /// </summary>
        public const string PHPUBFU8 = "PHPUBFU8";

        /// <summary>
        /// PHUSER.
        /// </summary>
        public const string PHUSER = "PHUSER";

        /// <summary>
        /// PHMKEY.
        /// </summary>
        public const string PHMKEY = "PHMKEY";

        /// <summary>
        /// PHJOBN.
        /// </summary>
        public const string PHJOBN = "PHJOBN";

        /// <summary>
        /// PHUPMJ.
        /// </summary>
        public const string PHUPMJ = "PHUPMJ";

        /// <summary>
        /// PHUPMT.
        /// </summary>
        public const string PHUPMT = "PHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F952336";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHPUBLISTID", "PHPUBLISTID", JdeDataType.String, 20, true, true),
        new JdeField("PHPUBLISTDES", "PHPUBLISTDES", JdeDataType.String, 200),
        new JdeField("PHPUBFU1", "PHPUBFU1", JdeDataType.String, 2),
        new JdeField("PHPUBFU2", "PHPUBFU2", JdeDataType.String, 2),
        new JdeField("PHPUBFU3", "PHPUBFU3", JdeDataType.String, 60),
        new JdeField("PHPUBFU4", "PHPUBFU4", JdeDataType.String, 60),
        new JdeField("PHPUBFU5", "PHPUBFU5", JdeDataType.Numeric),
        new JdeField("PHPUBFU6", "PHPUBFU6", JdeDataType.Numeric),
        new JdeField("PHPUBFU7", "PHPUBFU7", JdeDataType.String, 500),
        new JdeField("PHPUBFU8", "PHPUBFU8", JdeDataType.String, 500),
        new JdeField("PHUSER", "PHUSER", JdeDataType.String, 20),
        new JdeField("PHMKEY", "PHMKEY", JdeDataType.String, 30),
        new JdeField("PHJOBN", "PHJOBN", JdeDataType.String, 20),
        new JdeField("PHUPMJ", "PHUPMJ", JdeDataType.Numeric),
        new JdeField("PHUPMT", "PHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F952336_0", "Primary Key on PHPUBLISTID", new[] { "PHPUBLISTID" }, isUnique: true, isPrimaryKey: true)
    };
}
