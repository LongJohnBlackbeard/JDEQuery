using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B87 - .
/// </summary>
public class F31B87 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LOUKID.
        /// </summary>
        public const string LOUKID = "LOUKID";

        /// <summary>
        /// LOWOPID.
        /// </summary>
        public const string LOWOPID = "LOWOPID";

        /// <summary>
        /// LOWFROMVID.
        /// </summary>
        public const string LOWFROMVID = "LOWFROMVID";

        /// <summary>
        /// LOWTOVID.
        /// </summary>
        public const string LOWTOVID = "LOWTOVID";

        /// <summary>
        /// LOMCU.
        /// </summary>
        public const string LOMCU = "LOMCU";

        /// <summary>
        /// LOWOPN.
        /// </summary>
        public const string LOWOPN = "LOWOPN";

        /// <summary>
        /// LOWALOP.
        /// </summary>
        public const string LOWALOP = "LOWALOP";

        /// <summary>
        /// LOWCFGID.
        /// </summary>
        public const string LOWCFGID = "LOWCFGID";

        /// <summary>
        /// LOWCOPCD.
        /// </summary>
        public const string LOWCOPCD = "LOWCOPCD";

        /// <summary>
        /// LOWBOPCD.
        /// </summary>
        public const string LOWBOPCD = "LOWBOPCD";

        /// <summary>
        /// LOWASDT.
        /// </summary>
        public const string LOWASDT = "LOWASDT";

        /// <summary>
        /// LOWAEDT.
        /// </summary>
        public const string LOWAEDT = "LOWAEDT";

        /// <summary>
        /// LOUSER.
        /// </summary>
        public const string LOUSER = "LOUSER";

        /// <summary>
        /// LOWSD.
        /// </summary>
        public const string LOWSD = "LOWSD";

        /// <summary>
        /// LOWTSGL.
        /// </summary>
        public const string LOWTSGL = "LOWTSGL";

        /// <summary>
        /// LOWTOGL.
        /// </summary>
        public const string LOWTOGL = "LOWTOGL";

        /// <summary>
        /// LOWOPYL.
        /// </summary>
        public const string LOWOPYL = "LOWOPYL";

        /// <summary>
        /// LOWH1.
        /// </summary>
        public const string LOWH1 = "LOWH1";

        /// <summary>
        /// LOWH2.
        /// </summary>
        public const string LOWH2 = "LOWH2";

        /// <summary>
        /// LOWH3.
        /// </summary>
        public const string LOWH3 = "LOWH3";

        /// <summary>
        /// LOWH4.
        /// </summary>
        public const string LOWH4 = "LOWH4";

        /// <summary>
        /// LOWH5.
        /// </summary>
        public const string LOWH5 = "LOWH5";

        /// <summary>
        /// LOWFVTY.
        /// </summary>
        public const string LOWFVTY = "LOWFVTY";

        /// <summary>
        /// LOFRVNUM.
        /// </summary>
        public const string LOFRVNUM = "LOFRVNUM";

        /// <summary>
        /// LOWTVTY.
        /// </summary>
        public const string LOWTVTY = "LOWTVTY";

        /// <summary>
        /// LOTOVNUM.
        /// </summary>
        public const string LOTOVNUM = "LOTOVNUM";

        /// <summary>
        /// LOWBID.
        /// </summary>
        public const string LOWBID = "LOWBID";

        /// <summary>
        /// LOWABID.
        /// </summary>
        public const string LOWABID = "LOWABID";

        /// <summary>
        /// LOMATYP.
        /// </summary>
        public const string LOMATYP = "LOMATYP";

        /// <summary>
        /// LOAMATYP.
        /// </summary>
        public const string LOAMATYP = "LOAMATYP";

        /// <summary>
        /// LOWISSC.
        /// </summary>
        public const string LOWISSC = "LOWISSC";

        /// <summary>
        /// LOAWISSC.
        /// </summary>
        public const string LOAWISSC = "LOAWISSC";

        /// <summary>
        /// LOBFLTQNTY.
        /// </summary>
        public const string LOBFLTQNTY = "LOBFLTQNTY";

        /// <summary>
        /// LOBTLTQNTY.
        /// </summary>
        public const string LOBTLTQNTY = "LOBTLTQNTY";

        /// <summary>
        /// LOAFLTQNTY.
        /// </summary>
        public const string LOAFLTQNTY = "LOAFLTQNTY";

        /// <summary>
        /// LOATLTQNTY.
        /// </summary>
        public const string LOATLTQNTY = "LOATLTQNTY";

        /// <summary>
        /// LOWPLVLMV.
        /// </summary>
        public const string LOWPLVLMV = "LOWPLVLMV";

        /// <summary>
        /// LOWACTVLMV.
        /// </summary>
        public const string LOWACTVLMV = "LOWACTVLMV";

        /// <summary>
        /// LOWTMQ.
        /// </summary>
        public const string LOWTMQ = "LOWTMQ";

        /// <summary>
        /// LOWFB4LOTN.
        /// </summary>
        public const string LOWFB4LOTN = "LOWFB4LOTN";

        /// <summary>
        /// LOWTB4LOTN.
        /// </summary>
        public const string LOWTB4LOTN = "LOWTB4LOTN";

        /// <summary>
        /// LOWFAFLOTN.
        /// </summary>
        public const string LOWFAFLOTN = "LOWFAFLOTN";

        /// <summary>
        /// LOWTAFLOTN.
        /// </summary>
        public const string LOWTAFLOTN = "LOWTAFLOTN";
    }

    /// <inheritdoc />
    public override string TableName => "F31B87";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LOUKID", "LOUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("LOWOPID", "LOWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("LOWFROMVID", "LOWFROMVID", JdeDataType.Numeric, null, true, true),
        new JdeField("LOWTOVID", "LOWTOVID", JdeDataType.Numeric, null, true, true),
        new JdeField("LOMCU", "LOMCU", JdeDataType.String, 24),
        new JdeField("LOWOPN", "LOWOPN", JdeDataType.Numeric),
        new JdeField("LOWALOP", "LOWALOP", JdeDataType.String, 40),
        new JdeField("LOWCFGID", "LOWCFGID", JdeDataType.Numeric),
        new JdeField("LOWCOPCD", "LOWCOPCD", JdeDataType.String, 20),
        new JdeField("LOWBOPCD", "LOWBOPCD", JdeDataType.String, 20),
        new JdeField("LOWASDT", "LOWASDT", JdeDataType.Date),
        new JdeField("LOWAEDT", "LOWAEDT", JdeDataType.Date),
        new JdeField("LOUSER", "LOUSER", JdeDataType.String, 20),
        new JdeField("LOWSD", "LOWSD", JdeDataType.String, 60),
        new JdeField("LOWTSGL", "LOWTSGL", JdeDataType.Numeric),
        new JdeField("LOWTOGL", "LOWTOGL", JdeDataType.Numeric),
        new JdeField("LOWOPYL", "LOWOPYL", JdeDataType.Numeric),
        new JdeField("LOWH1", "LOWH1", JdeDataType.String, 20),
        new JdeField("LOWH2", "LOWH2", JdeDataType.String, 20),
        new JdeField("LOWH3", "LOWH3", JdeDataType.String, 20),
        new JdeField("LOWH4", "LOWH4", JdeDataType.String, 20),
        new JdeField("LOWH5", "LOWH5", JdeDataType.String, 20),
        new JdeField("LOWFVTY", "LOWFVTY", JdeDataType.String, 2),
        new JdeField("LOFRVNUM", "LOFRVNUM", JdeDataType.String, 60),
        new JdeField("LOWTVTY", "LOWTVTY", JdeDataType.String, 2),
        new JdeField("LOTOVNUM", "LOTOVNUM", JdeDataType.String, 60),
        new JdeField("LOWBID", "LOWBID", JdeDataType.String, 60),
        new JdeField("LOWABID", "LOWABID", JdeDataType.String, 60),
        new JdeField("LOMATYP", "LOMATYP", JdeDataType.String, 8),
        new JdeField("LOAMATYP", "LOAMATYP", JdeDataType.String, 8),
        new JdeField("LOWISSC", "LOWISSC", JdeDataType.String, 12),
        new JdeField("LOAWISSC", "LOAWISSC", JdeDataType.String, 12),
        new JdeField("LOBFLTQNTY", "LOBFLTQNTY", JdeDataType.Numeric),
        new JdeField("LOBTLTQNTY", "LOBTLTQNTY", JdeDataType.Numeric),
        new JdeField("LOAFLTQNTY", "LOAFLTQNTY", JdeDataType.Numeric),
        new JdeField("LOATLTQNTY", "LOATLTQNTY", JdeDataType.Numeric),
        new JdeField("LOWPLVLMV", "LOWPLVLMV", JdeDataType.Numeric),
        new JdeField("LOWACTVLMV", "LOWACTVLMV", JdeDataType.Numeric),
        new JdeField("LOWTMQ", "LOWTMQ", JdeDataType.Numeric),
        new JdeField("LOWFB4LOTN", "LOWFB4LOTN", JdeDataType.String, 60),
        new JdeField("LOWTB4LOTN", "LOWTB4LOTN", JdeDataType.String, 60),
        new JdeField("LOWFAFLOTN", "LOWFAFLOTN", JdeDataType.String, 60),
        new JdeField("LOWTAFLOTN", "LOWTAFLOTN", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B87_0", "Primary Key on LOUKID, LOWOPID, LOWFROMVID, LOWTOVID", new[] { "LOUKID", "LOWOPID", "LOWFROMVID", "LOWTOVID" }, isUnique: true, isPrimaryKey: true)
    };
}
