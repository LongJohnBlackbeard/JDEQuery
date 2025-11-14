using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B5103 - .
/// </summary>
public class F31B5103 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADUKID.
        /// </summary>
        public const string ADUKID = "ADUKID";

        /// <summary>
        /// ADWOPID.
        /// </summary>
        public const string ADWOPID = "ADWOPID";

        /// <summary>
        /// ADWOPN.
        /// </summary>
        public const string ADWOPN = "ADWOPN";

        /// <summary>
        /// ADMMCU.
        /// </summary>
        public const string ADMMCU = "ADMMCU";

        /// <summary>
        /// ADMATYP.
        /// </summary>
        public const string ADMATYP = "ADMATYP";

        /// <summary>
        /// ADWCOPCD.
        /// </summary>
        public const string ADWCOPCD = "ADWCOPCD";

        /// <summary>
        /// ADLOTV.
        /// </summary>
        public const string ADLOTV = "ADLOTV";

        /// <summary>
        /// ADWTBOQTY.
        /// </summary>
        public const string ADWTBOQTY = "ADWTBOQTY";

        /// <summary>
        /// ADWVUM.
        /// </summary>
        public const string ADWVUM = "ADWVUM";

        /// <summary>
        /// ADLTQNTY.
        /// </summary>
        public const string ADLTQNTY = "ADLTQNTY";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADJOBN.
        /// </summary>
        public const string ADJOBN = "ADJOBN";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADTDAY.
        /// </summary>
        public const string ADTDAY = "ADTDAY";

        /// <summary>
        /// ADURCD.
        /// </summary>
        public const string ADURCD = "ADURCD";

        /// <summary>
        /// ADURAB.
        /// </summary>
        public const string ADURAB = "ADURAB";

        /// <summary>
        /// ADURAT.
        /// </summary>
        public const string ADURAT = "ADURAT";

        /// <summary>
        /// ADURDT.
        /// </summary>
        public const string ADURDT = "ADURDT";

        /// <summary>
        /// ADURRF.
        /// </summary>
        public const string ADURRF = "ADURRF";

        /// <summary>
        /// ADFFU3.
        /// </summary>
        public const string ADFFU3 = "ADFFU3";

        /// <summary>
        /// ADFFU5.
        /// </summary>
        public const string ADFFU5 = "ADFFU5";

        /// <summary>
        /// ADFFU6.
        /// </summary>
        public const string ADFFU6 = "ADFFU6";

        /// <summary>
        /// ADFFU4.
        /// </summary>
        public const string ADFFU4 = "ADFFU4";

        /// <summary>
        /// ADFFU7.
        /// </summary>
        public const string ADFFU7 = "ADFFU7";

        /// <summary>
        /// ADFFU8.
        /// </summary>
        public const string ADFFU8 = "ADFFU8";

        /// <summary>
        /// ADTFUDJ.
        /// </summary>
        public const string ADTFUDJ = "ADTFUDJ";

        /// <summary>
        /// ADTFUDJ2.
        /// </summary>
        public const string ADTFUDJ2 = "ADTFUDJ2";

        /// <summary>
        /// ADTFUDJ3.
        /// </summary>
        public const string ADTFUDJ3 = "ADTFUDJ3";
    }

    /// <inheritdoc />
    public override string TableName => "F31B5103";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADUKID", "ADUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ADWOPID", "ADWOPID", JdeDataType.Numeric),
        new JdeField("ADWOPN", "ADWOPN", JdeDataType.Numeric),
        new JdeField("ADMMCU", "ADMMCU", JdeDataType.String, 24),
        new JdeField("ADMATYP", "ADMATYP", JdeDataType.String, 8),
        new JdeField("ADWCOPCD", "ADWCOPCD", JdeDataType.String, 20),
        new JdeField("ADLOTV", "ADLOTV", JdeDataType.String, 60),
        new JdeField("ADWTBOQTY", "ADWTBOQTY", JdeDataType.Numeric),
        new JdeField("ADWVUM", "ADWVUM", JdeDataType.String, 6),
        new JdeField("ADLTQNTY", "ADLTQNTY", JdeDataType.Numeric),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADJOBN", "ADJOBN", JdeDataType.String, 20),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADTDAY", "ADTDAY", JdeDataType.Numeric),
        new JdeField("ADURCD", "ADURCD", JdeDataType.String, 4),
        new JdeField("ADURAB", "ADURAB", JdeDataType.Numeric),
        new JdeField("ADURAT", "ADURAT", JdeDataType.Numeric),
        new JdeField("ADURDT", "ADURDT", JdeDataType.Numeric),
        new JdeField("ADURRF", "ADURRF", JdeDataType.String, 30),
        new JdeField("ADFFU3", "ADFFU3", JdeDataType.String, 20),
        new JdeField("ADFFU5", "ADFFU5", JdeDataType.String, 20),
        new JdeField("ADFFU6", "ADFFU6", JdeDataType.String, 20),
        new JdeField("ADFFU4", "ADFFU4", JdeDataType.Numeric),
        new JdeField("ADFFU7", "ADFFU7", JdeDataType.Numeric),
        new JdeField("ADFFU8", "ADFFU8", JdeDataType.Numeric),
        new JdeField("ADTFUDJ", "ADTFUDJ", JdeDataType.Numeric),
        new JdeField("ADTFUDJ2", "ADTFUDJ2", JdeDataType.Numeric),
        new JdeField("ADTFUDJ3", "ADTFUDJ3", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B5103_0", "Primary Key on ADUKID", new[] { "ADUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B5103_2", "Index on ADWOPID", new[] { "ADWOPID" })
    };
}
