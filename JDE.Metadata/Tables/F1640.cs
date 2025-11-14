using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1640 - .
/// </summary>
public class F1640 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AMACTB.
        /// </summary>
        public const string AMACTB = "AMACTB";

        /// <summary>
        /// AMDL01.
        /// </summary>
        public const string AMDL01 = "AMDL01";

        /// <summary>
        /// AMACGR.
        /// </summary>
        public const string AMACGR = "AMACGR";

        /// <summary>
        /// AMPARA.
        /// </summary>
        public const string AMPARA = "AMPARA";

        /// <summary>
        /// AMDRCD.
        /// </summary>
        public const string AMDRCD = "AMDRCD";

        /// <summary>
        /// AMATR1.
        /// </summary>
        public const string AMATR1 = "AMATR1";

        /// <summary>
        /// AMATR2.
        /// </summary>
        public const string AMATR2 = "AMATR2";

        /// <summary>
        /// AMATR3.
        /// </summary>
        public const string AMATR3 = "AMATR3";

        /// <summary>
        /// AMATR4.
        /// </summary>
        public const string AMATR4 = "AMATR4";

        /// <summary>
        /// AMATR5.
        /// </summary>
        public const string AMATR5 = "AMATR5";

        /// <summary>
        /// AMACC1.
        /// </summary>
        public const string AMACC1 = "AMACC1";

        /// <summary>
        /// AMACC2.
        /// </summary>
        public const string AMACC2 = "AMACC2";

        /// <summary>
        /// AMACC3.
        /// </summary>
        public const string AMACC3 = "AMACC3";

        /// <summary>
        /// AMACC4.
        /// </summary>
        public const string AMACC4 = "AMACC4";

        /// <summary>
        /// AMACC5.
        /// </summary>
        public const string AMACC5 = "AMACC5";

        /// <summary>
        /// AMLLX.
        /// </summary>
        public const string AMLLX = "AMLLX";

        /// <summary>
        /// AMUSER.
        /// </summary>
        public const string AMUSER = "AMUSER";

        /// <summary>
        /// AMPID.
        /// </summary>
        public const string AMPID = "AMPID";

        /// <summary>
        /// AMUPMJ.
        /// </summary>
        public const string AMUPMJ = "AMUPMJ";

        /// <summary>
        /// AMUPMT.
        /// </summary>
        public const string AMUPMT = "AMUPMT";

        /// <summary>
        /// AMJOBN.
        /// </summary>
        public const string AMJOBN = "AMJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F1640";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AMACTB", "AMACTB", JdeDataType.String, 20, true, true),
        new JdeField("AMDL01", "AMDL01", JdeDataType.String, 60),
        new JdeField("AMACGR", "AMACGR", JdeDataType.String, 2),
        new JdeField("AMPARA", "AMPARA", JdeDataType.String, 20),
        new JdeField("AMDRCD", "AMDRCD", JdeDataType.String, 20),
        new JdeField("AMATR1", "AMATR1", JdeDataType.String, 2),
        new JdeField("AMATR2", "AMATR2", JdeDataType.String, 2),
        new JdeField("AMATR3", "AMATR3", JdeDataType.String, 2),
        new JdeField("AMATR4", "AMATR4", JdeDataType.String, 2),
        new JdeField("AMATR5", "AMATR5", JdeDataType.String, 2),
        new JdeField("AMACC1", "AMACC1", JdeDataType.String, 20),
        new JdeField("AMACC2", "AMACC2", JdeDataType.String, 20),
        new JdeField("AMACC3", "AMACC3", JdeDataType.String, 20),
        new JdeField("AMACC4", "AMACC4", JdeDataType.String, 20),
        new JdeField("AMACC5", "AMACC5", JdeDataType.String, 20),
        new JdeField("AMLLX", "AMLLX", JdeDataType.Numeric),
        new JdeField("AMUSER", "AMUSER", JdeDataType.String, 20),
        new JdeField("AMPID", "AMPID", JdeDataType.String, 20),
        new JdeField("AMUPMJ", "AMUPMJ", JdeDataType.Numeric),
        new JdeField("AMUPMT", "AMUPMT", JdeDataType.Numeric),
        new JdeField("AMJOBN", "AMJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1640_0", "Primary Key on AMACTB", new[] { "AMACTB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1640_3", "Index on AMPARA, AMLLX, AMACTB", new[] { "AMPARA", "AMLLX", "AMACTB" })
    };
}
