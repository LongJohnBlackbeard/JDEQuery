using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F9900003 - .
/// </summary>
public class F9900003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SUPARS.
        /// </summary>
        public const string SUPARS = "SUPARS";

        /// <summary>
        /// SUTYPR.
        /// </summary>
        public const string SUTYPR = "SUTYPR";

        /// <summary>
        /// SUANM1.
        /// </summary>
        public const string SUANM1 = "SUANM1";

        /// <summary>
        /// SUANM2.
        /// </summary>
        public const string SUANM2 = "SUANM2";

        /// <summary>
        /// SUANM3.
        /// </summary>
        public const string SUANM3 = "SUANM3";

        /// <summary>
        /// SUDOCO.
        /// </summary>
        public const string SUDOCO = "SUDOCO";

        /// <summary>
        /// SUDL01.
        /// </summary>
        public const string SUDL01 = "SUDL01";

        /// <summary>
        /// SUTYPS.
        /// </summary>
        public const string SUTYPS = "SUTYPS";

        /// <summary>
        /// SUPRTS.
        /// </summary>
        public const string SUPRTS = "SUPRTS";

        /// <summary>
        /// SUSRST.
        /// </summary>
        public const string SUSRST = "SUSRST";

        /// <summary>
        /// SUWR01.
        /// </summary>
        public const string SUWR01 = "SUWR01";

        /// <summary>
        /// SUERR.
        /// </summary>
        public const string SUERR = "SUERR";

        /// <summary>
        /// SUUSER.
        /// </summary>
        public const string SUUSER = "SUUSER";

        /// <summary>
        /// SUUPMJ.
        /// </summary>
        public const string SUUPMJ = "SUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F9900003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SUPARS", "SUPARS", JdeDataType.String, 16, true, true),
        new JdeField("SUTYPR", "SUTYPR", JdeDataType.String, 2, true, true),
        new JdeField("SUANM1", "SUANM1", JdeDataType.String, 20, true, true),
        new JdeField("SUANM2", "SUANM2", JdeDataType.String, 20, true, true),
        new JdeField("SUANM3", "SUANM3", JdeDataType.String, 20, true, true),
        new JdeField("SUDOCO", "SUDOCO", JdeDataType.Numeric),
        new JdeField("SUDL01", "SUDL01", JdeDataType.String, 60),
        new JdeField("SUTYPS", "SUTYPS", JdeDataType.String, 2),
        new JdeField("SUPRTS", "SUPRTS", JdeDataType.String, 2),
        new JdeField("SUSRST", "SUSRST", JdeDataType.String, 4),
        new JdeField("SUWR01", "SUWR01", JdeDataType.String, 8),
        new JdeField("SUERR", "SUERR", JdeDataType.String, 2),
        new JdeField("SUUSER", "SUUSER", JdeDataType.String, 20),
        new JdeField("SUUPMJ", "SUUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F9900003_0", "Primary Key on SUPARS, SUTYPR, SUANM1, SUANM2, SUANM3", new[] { "SUPARS", "SUTYPR", "SUANM1", "SUANM2", "SUANM3" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F9900003_2", "Index on SUPARS, SUUSER", new[] { "SUPARS", "SUUSER" })
    };
}
