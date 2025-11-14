using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4826 - .
/// </summary>
public class F4826 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GEDCTO.
        /// </summary>
        public const string GEDCTO = "GEDCTO";

        /// <summary>
        /// GETYPS.
        /// </summary>
        public const string GETYPS = "GETYPS";

        /// <summary>
        /// GESRST.
        /// </summary>
        public const string GESRST = "GESRST";

        /// <summary>
        /// GENTST.
        /// </summary>
        public const string GENTST = "GENTST";

        /// <summary>
        /// GEA1ST.
        /// </summary>
        public const string GEA1ST = "GEA1ST";

        /// <summary>
        /// GEA2ST.
        /// </summary>
        public const string GEA2ST = "GEA2ST";

        /// <summary>
        /// GEA3ST.
        /// </summary>
        public const string GEA3ST = "GEA3ST";

        /// <summary>
        /// GEA4ST.
        /// </summary>
        public const string GEA4ST = "GEA4ST";

        /// <summary>
        /// GEA5ST.
        /// </summary>
        public const string GEA5ST = "GEA5ST";

        /// <summary>
        /// GEMSTS.
        /// </summary>
        public const string GEMSTS = "GEMSTS";

        /// <summary>
        /// GEIVCM.
        /// </summary>
        public const string GEIVCM = "GEIVCM";

        /// <summary>
        /// GESBLI.
        /// </summary>
        public const string GESBLI = "GESBLI";

        /// <summary>
        /// GEEQW1.
        /// </summary>
        public const string GEEQW1 = "GEEQW1";

        /// <summary>
        /// GEEQW2.
        /// </summary>
        public const string GEEQW2 = "GEEQW2";

        /// <summary>
        /// GEEQW3.
        /// </summary>
        public const string GEEQW3 = "GEEQW3";

        /// <summary>
        /// GEEQW4.
        /// </summary>
        public const string GEEQW4 = "GEEQW4";

        /// <summary>
        /// GEEQW5.
        /// </summary>
        public const string GEEQW5 = "GEEQW5";

        /// <summary>
        /// GEBUDG.
        /// </summary>
        public const string GEBUDG = "GEBUDG";

        /// <summary>
        /// GEUSER.
        /// </summary>
        public const string GEUSER = "GEUSER";

        /// <summary>
        /// GEPID.
        /// </summary>
        public const string GEPID = "GEPID";

        /// <summary>
        /// GEUPMJ.
        /// </summary>
        public const string GEUPMJ = "GEUPMJ";

        /// <summary>
        /// GEJOBN.
        /// </summary>
        public const string GEJOBN = "GEJOBN";

        /// <summary>
        /// GEWOWRTL.
        /// </summary>
        public const string GEWOWRTL = "GEWOWRTL";

        /// <summary>
        /// GEPLWRTL.
        /// </summary>
        public const string GEPLWRTL = "GEPLWRTL";

        /// <summary>
        /// GEROWRTL.
        /// </summary>
        public const string GEROWRTL = "GEROWRTL";
    }

    /// <inheritdoc />
    public override string TableName => "F4826";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GEDCTO", "GEDCTO", JdeDataType.String, 4, true, true),
        new JdeField("GETYPS", "GETYPS", JdeDataType.String, 2, true, true),
        new JdeField("GESRST", "GESRST", JdeDataType.String, 4, true, true),
        new JdeField("GENTST", "GENTST", JdeDataType.String, 4),
        new JdeField("GEA1ST", "GEA1ST", JdeDataType.String, 4),
        new JdeField("GEA2ST", "GEA2ST", JdeDataType.String, 4),
        new JdeField("GEA3ST", "GEA3ST", JdeDataType.String, 4),
        new JdeField("GEA4ST", "GEA4ST", JdeDataType.String, 4),
        new JdeField("GEA5ST", "GEA5ST", JdeDataType.String, 4),
        new JdeField("GEMSTS", "GEMSTS", JdeDataType.String, 4),
        new JdeField("GEIVCM", "GEIVCM", JdeDataType.String, 2),
        new JdeField("GESBLI", "GESBLI", JdeDataType.String, 2),
        new JdeField("GEEQW1", "GEEQW1", JdeDataType.String, 2),
        new JdeField("GEEQW2", "GEEQW2", JdeDataType.String, 2),
        new JdeField("GEEQW3", "GEEQW3", JdeDataType.String, 2),
        new JdeField("GEEQW4", "GEEQW4", JdeDataType.String, 2),
        new JdeField("GEEQW5", "GEEQW5", JdeDataType.String, 2),
        new JdeField("GEBUDG", "GEBUDG", JdeDataType.String, 2),
        new JdeField("GEUSER", "GEUSER", JdeDataType.String, 20),
        new JdeField("GEPID", "GEPID", JdeDataType.String, 20),
        new JdeField("GEUPMJ", "GEUPMJ", JdeDataType.Numeric),
        new JdeField("GEJOBN", "GEJOBN", JdeDataType.String, 20),
        new JdeField("GEWOWRTL", "GEWOWRTL", JdeDataType.String, 2),
        new JdeField("GEPLWRTL", "GEPLWRTL", JdeDataType.String, 2),
        new JdeField("GEROWRTL", "GEROWRTL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4826_0", "Primary Key on GEDCTO, GETYPS, GESRST", new[] { "GEDCTO", "GETYPS", "GESRST" }, isUnique: true, isPrimaryKey: true)
    };
}
