using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A039 - .
/// </summary>
public class F79A039 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GD79AGESID.
        /// </summary>
        public const string GD79AGESID = "GD79AGESID";

        /// <summary>
        /// GD79ASRC.
        /// </summary>
        public const string GD79ASRC = "GD79ASRC";

        /// <summary>
        /// GD79AEMSD.
        /// </summary>
        public const string GD79AEMSD = "GD79AEMSD";

        /// <summary>
        /// GD79AEMSC.
        /// </summary>
        public const string GD79AEMSC = "GD79AEMSC";

        /// <summary>
        /// GD79AEMD.
        /// </summary>
        public const string GD79AEMD = "GD79AEMD";

        /// <summary>
        /// GD79AGMDR.
        /// </summary>
        public const string GD79AGMDR = "GD79AGMDR";

        /// <summary>
        /// GD79AGC01.
        /// </summary>
        public const string GD79AGC01 = "GD79AGC01";

        /// <summary>
        /// GD79AGC02.
        /// </summary>
        public const string GD79AGC02 = "GD79AGC02";

        /// <summary>
        /// GD79AGC03.
        /// </summary>
        public const string GD79AGC03 = "GD79AGC03";

        /// <summary>
        /// GD79AGC04.
        /// </summary>
        public const string GD79AGC04 = "GD79AGC04";

        /// <summary>
        /// GD79AGC05.
        /// </summary>
        public const string GD79AGC05 = "GD79AGC05";

        /// <summary>
        /// GD79AGC06.
        /// </summary>
        public const string GD79AGC06 = "GD79AGC06";

        /// <summary>
        /// GD79AGC07.
        /// </summary>
        public const string GD79AGC07 = "GD79AGC07";

        /// <summary>
        /// GD79AGC08.
        /// </summary>
        public const string GD79AGC08 = "GD79AGC08";

        /// <summary>
        /// GD79AGC09.
        /// </summary>
        public const string GD79AGC09 = "GD79AGC09";

        /// <summary>
        /// GD79AGC10.
        /// </summary>
        public const string GD79AGC10 = "GD79AGC10";

        /// <summary>
        /// GD79AGPES.
        /// </summary>
        public const string GD79AGPES = "GD79AGPES";

        /// <summary>
        /// GDURCD.
        /// </summary>
        public const string GDURCD = "GDURCD";

        /// <summary>
        /// GDURRF.
        /// </summary>
        public const string GDURRF = "GDURRF";

        /// <summary>
        /// GDURDT.
        /// </summary>
        public const string GDURDT = "GDURDT";

        /// <summary>
        /// GDURAB.
        /// </summary>
        public const string GDURAB = "GDURAB";

        /// <summary>
        /// GDURAT.
        /// </summary>
        public const string GDURAT = "GDURAT";

        /// <summary>
        /// GDPID.
        /// </summary>
        public const string GDPID = "GDPID";

        /// <summary>
        /// GDUSER.
        /// </summary>
        public const string GDUSER = "GDUSER";

        /// <summary>
        /// GDJOBN.
        /// </summary>
        public const string GDJOBN = "GDJOBN";

        /// <summary>
        /// GDUPMJ.
        /// </summary>
        public const string GDUPMJ = "GDUPMJ";

        /// <summary>
        /// GDUPMT.
        /// </summary>
        public const string GDUPMT = "GDUPMT";

        /// <summary>
        /// GD79AUMC.
        /// </summary>
        public const string GD79AUMC = "GD79AUMC";

        /// <summary>
        /// GD79AOPS.
        /// </summary>
        public const string GD79AOPS = "GD79AOPS";

        /// <summary>
        /// GD79AOSC.
        /// </summary>
        public const string GD79AOSC = "GD79AOSC";

        /// <summary>
        /// GD79AOAT.
        /// </summary>
        public const string GD79AOAT = "GD79AOAT";

        /// <summary>
        /// GDACTN.
        /// </summary>
        public const string GDACTN = "GDACTN";
    }

    /// <inheritdoc />
    public override string TableName => "F79A039";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GD79AGESID", "GD79AGESID", JdeDataType.Numeric, null, true, true),
        new JdeField("GD79ASRC", "GD79ASRC", JdeDataType.String, 50),
        new JdeField("GD79AEMSD", "GD79AEMSD", JdeDataType.String, 200),
        new JdeField("GD79AEMSC", "GD79AEMSC", JdeDataType.String, 20),
        new JdeField("GD79AEMD", "GD79AEMD", JdeDataType.String, 30),
        new JdeField("GD79AGMDR", "GD79AGMDR", JdeDataType.String, 2),
        new JdeField("GD79AGC01", "GD79AGC01", JdeDataType.String, 6),
        new JdeField("GD79AGC02", "GD79AGC02", JdeDataType.String, 6),
        new JdeField("GD79AGC03", "GD79AGC03", JdeDataType.String, 6),
        new JdeField("GD79AGC04", "GD79AGC04", JdeDataType.String, 6),
        new JdeField("GD79AGC05", "GD79AGC05", JdeDataType.String, 6),
        new JdeField("GD79AGC06", "GD79AGC06", JdeDataType.String, 6),
        new JdeField("GD79AGC07", "GD79AGC07", JdeDataType.String, 6),
        new JdeField("GD79AGC08", "GD79AGC08", JdeDataType.String, 6),
        new JdeField("GD79AGC09", "GD79AGC09", JdeDataType.String, 6),
        new JdeField("GD79AGC10", "GD79AGC10", JdeDataType.String, 6),
        new JdeField("GD79AGPES", "GD79AGPES", JdeDataType.String, 50),
        new JdeField("GDURCD", "GDURCD", JdeDataType.String, 4),
        new JdeField("GDURRF", "GDURRF", JdeDataType.String, 30),
        new JdeField("GDURDT", "GDURDT", JdeDataType.Numeric),
        new JdeField("GDURAB", "GDURAB", JdeDataType.Numeric),
        new JdeField("GDURAT", "GDURAT", JdeDataType.Numeric),
        new JdeField("GDPID", "GDPID", JdeDataType.String, 20),
        new JdeField("GDUSER", "GDUSER", JdeDataType.String, 20),
        new JdeField("GDJOBN", "GDJOBN", JdeDataType.String, 20),
        new JdeField("GDUPMJ", "GDUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("GDUPMT", "GDUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("GD79AUMC", "GD79AUMC", JdeDataType.String, 50),
        new JdeField("GD79AOPS", "GD79AOPS", JdeDataType.String, 30),
        new JdeField("GD79AOSC", "GD79AOSC", JdeDataType.String, 30),
        new JdeField("GD79AOAT", "GD79AOAT", JdeDataType.String, 30),
        new JdeField("GDACTN", "GDACTN", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A039_0", "Primary Key on GD79AGESID, GDUPMJ, GDUPMT, GDACTN", new[] { "GD79AGESID", "GDUPMJ", "GDUPMT", "GDACTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A039_2", "Index on GD79ASRC, GDUPMJ, GDUPMT", new[] { "GD79ASRC", "GDUPMJ", "GDUPMT" })
    };
}
