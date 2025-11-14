using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L707 - .
/// </summary>
public class FF30L707 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PLPHID.
        /// </summary>
        public const string PLPHID = "PLPHID";

        /// <summary>
        /// PLPPPID.
        /// </summary>
        public const string PLPPPID = "PLPPPID";

        /// <summary>
        /// PLSPROID.
        /// </summary>
        public const string PLSPROID = "PLSPROID";

        /// <summary>
        /// PLPHTY.
        /// </summary>
        public const string PLPHTY = "PLPHTY";

        /// <summary>
        /// PLRPPID.
        /// </summary>
        public const string PLRPPID = "PLRPPID";

        /// <summary>
        /// PLRPROID.
        /// </summary>
        public const string PLRPROID = "PLRPROID";

        /// <summary>
        /// PLPPHID.
        /// </summary>
        public const string PLPPHID = "PLPPHID";

        /// <summary>
        /// PLPHRWP.
        /// </summary>
        public const string PLPHRWP = "PLPHRWP";

        /// <summary>
        /// PLRWLP.
        /// </summary>
        public const string PLRWLP = "PLRWLP";

        /// <summary>
        /// PLODPC.
        /// </summary>
        public const string PLODPC = "PLODPC";

        /// <summary>
        /// PLOPPC.
        /// </summary>
        public const string PLOPPC = "PLOPPC";

        /// <summary>
        /// PLFSCID.
        /// </summary>
        public const string PLFSCID = "PLFSCID";

        /// <summary>
        /// PLURCD.
        /// </summary>
        public const string PLURCD = "PLURCD";

        /// <summary>
        /// PLURDT.
        /// </summary>
        public const string PLURDT = "PLURDT";

        /// <summary>
        /// PLURAT.
        /// </summary>
        public const string PLURAT = "PLURAT";

        /// <summary>
        /// PLURAB.
        /// </summary>
        public const string PLURAB = "PLURAB";

        /// <summary>
        /// PLURRF.
        /// </summary>
        public const string PLURRF = "PLURRF";

        /// <summary>
        /// PLUSER.
        /// </summary>
        public const string PLUSER = "PLUSER";

        /// <summary>
        /// PLPID.
        /// </summary>
        public const string PLPID = "PLPID";

        /// <summary>
        /// PLMKEY.
        /// </summary>
        public const string PLMKEY = "PLMKEY";

        /// <summary>
        /// PLUUPMJ.
        /// </summary>
        public const string PLUUPMJ = "PLUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L707";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PLPHID", "PLPHID", JdeDataType.Numeric, null, true, true),
        new JdeField("PLPPPID", "PLPPPID", JdeDataType.Numeric, null, true, true),
        new JdeField("PLSPROID", "PLSPROID", JdeDataType.Numeric),
        new JdeField("PLPHTY", "PLPHTY", JdeDataType.String, 4),
        new JdeField("PLRPPID", "PLRPPID", JdeDataType.Numeric),
        new JdeField("PLRPROID", "PLRPROID", JdeDataType.Numeric),
        new JdeField("PLPPHID", "PLPPHID", JdeDataType.Numeric),
        new JdeField("PLPHRWP", "PLPHRWP", JdeDataType.Numeric),
        new JdeField("PLRWLP", "PLRWLP", JdeDataType.Numeric),
        new JdeField("PLODPC", "PLODPC", JdeDataType.Numeric),
        new JdeField("PLOPPC", "PLOPPC", JdeDataType.Numeric),
        new JdeField("PLFSCID", "PLFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("PLURCD", "PLURCD", JdeDataType.String, 4),
        new JdeField("PLURDT", "PLURDT", JdeDataType.Numeric),
        new JdeField("PLURAT", "PLURAT", JdeDataType.Numeric),
        new JdeField("PLURAB", "PLURAB", JdeDataType.Numeric),
        new JdeField("PLURRF", "PLURRF", JdeDataType.String, 30),
        new JdeField("PLUSER", "PLUSER", JdeDataType.String, 20),
        new JdeField("PLPID", "PLPID", JdeDataType.String, 20),
        new JdeField("PLMKEY", "PLMKEY", JdeDataType.String, 30),
        new JdeField("PLUUPMJ", "PLUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L707_0", "Primary Key on PLPHID, PLPPPID, PLFSCID", new[] { "PLPHID", "PLPPPID", "PLFSCID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L707_2", "Index on PLFSCID, PLPHID", new[] { "PLFSCID", "PLPHID" }),
        new JdeIndex("FF30L707_3", "Index on PLFSCID, PLPPHID", new[] { "PLFSCID", "PLPPHID" }),
        new JdeIndex("FF30L707_4", "Index on PLPPHID", new[] { "PLPPHID" }),
        new JdeIndex("FF30L707_5", "Index on PLPPHID, PLFSCID", new[] { "PLPPHID", "PLFSCID" }),
        new JdeIndex("FF30L707_6", "Index on PLPPPID, PLPHTY", new[] { "PLPPPID", "PLPHTY" }),
        new JdeIndex("FF30L707_7", "Index on PLRPPID, PLPHTY", new[] { "PLRPPID", "PLPHTY" })
    };
}
