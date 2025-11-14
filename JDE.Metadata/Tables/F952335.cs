using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F952335 - .
/// </summary>
public class F952335 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GUGENURLID.
        /// </summary>
        public const string GUGENURLID = "GUGENURLID";

        /// <summary>
        /// GUGENUSER.
        /// </summary>
        public const string GUGENUSER = "GUGENUSER";

        /// <summary>
        /// GUACSROLE.
        /// </summary>
        public const string GUACSROLE = "GUACSROLE";

        /// <summary>
        /// GUGUFU1.
        /// </summary>
        public const string GUGUFU1 = "GUGUFU1";

        /// <summary>
        /// GUGUFU2.
        /// </summary>
        public const string GUGUFU2 = "GUGUFU2";

        /// <summary>
        /// GUGUFU3.
        /// </summary>
        public const string GUGUFU3 = "GUGUFU3";

        /// <summary>
        /// GUGUFU4.
        /// </summary>
        public const string GUGUFU4 = "GUGUFU4";

        /// <summary>
        /// GUGUFU5.
        /// </summary>
        public const string GUGUFU5 = "GUGUFU5";

        /// <summary>
        /// GUGUFU6.
        /// </summary>
        public const string GUGUFU6 = "GUGUFU6";

        /// <summary>
        /// GUGUFU7.
        /// </summary>
        public const string GUGUFU7 = "GUGUFU7";

        /// <summary>
        /// GUGUFU8.
        /// </summary>
        public const string GUGUFU8 = "GUGUFU8";

        /// <summary>
        /// GUUSER.
        /// </summary>
        public const string GUUSER = "GUUSER";

        /// <summary>
        /// GUPID.
        /// </summary>
        public const string GUPID = "GUPID";

        /// <summary>
        /// GUUPMJ.
        /// </summary>
        public const string GUUPMJ = "GUUPMJ";

        /// <summary>
        /// GUUPMT.
        /// </summary>
        public const string GUUPMT = "GUUPMT";

        /// <summary>
        /// GUMKEY.
        /// </summary>
        public const string GUMKEY = "GUMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F952335";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GUGENURLID", "GUGENURLID", JdeDataType.String, 140, true, true),
        new JdeField("GUGENUSER", "GUGENUSER", JdeDataType.String, 20, true, true),
        new JdeField("GUACSROLE", "GUACSROLE", JdeDataType.String, 20),
        new JdeField("GUGUFU1", "GUGUFU1", JdeDataType.String, 60),
        new JdeField("GUGUFU2", "GUGUFU2", JdeDataType.String, 60),
        new JdeField("GUGUFU3", "GUGUFU3", JdeDataType.Numeric),
        new JdeField("GUGUFU4", "GUGUFU4", JdeDataType.Numeric),
        new JdeField("GUGUFU5", "GUGUFU5", JdeDataType.String, 500),
        new JdeField("GUGUFU6", "GUGUFU6", JdeDataType.String, 500),
        new JdeField("GUGUFU7", "GUGUFU7", JdeDataType.String, 2),
        new JdeField("GUGUFU8", "GUGUFU8", JdeDataType.String, 2),
        new JdeField("GUUSER", "GUUSER", JdeDataType.String, 20),
        new JdeField("GUPID", "GUPID", JdeDataType.String, 20),
        new JdeField("GUUPMJ", "GUUPMJ", JdeDataType.Numeric),
        new JdeField("GUUPMT", "GUUPMT", JdeDataType.Numeric),
        new JdeField("GUMKEY", "GUMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F952335_0", "Primary Key on GUGENURLID, GUGENUSER", new[] { "GUGENURLID", "GUGENUSER" }, isUnique: true, isPrimaryKey: true)
    };
}
