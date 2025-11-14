using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F45510 - .
/// </summary>
public class F45510 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SHSANAME.
        /// </summary>
        public const string SHSANAME = "SHSANAME";

        /// <summary>
        /// SHSADESC.
        /// </summary>
        public const string SHSADESC = "SHSADESC";

        /// <summary>
        /// SHOMWTBLNM.
        /// </summary>
        public const string SHOMWTBLNM = "SHOMWTBLNM";

        /// <summary>
        /// SHSASECUR.
        /// </summary>
        public const string SHSASECUR = "SHSASECUR";

        /// <summary>
        /// SHSADIRNB.
        /// </summary>
        public const string SHSADIRNB = "SHSADIRNB";

        /// <summary>
        /// SHSAMAXVL.
        /// </summary>
        public const string SHSAMAXVL = "SHSAMAXVL";

        /// <summary>
        /// SHSAADDSEL.
        /// </summary>
        public const string SHSAADDSEL = "SHSAADDSEL";

        /// <summary>
        /// SHUSER.
        /// </summary>
        public const string SHUSER = "SHUSER";

        /// <summary>
        /// SHPID.
        /// </summary>
        public const string SHPID = "SHPID";

        /// <summary>
        /// SHJOBN.
        /// </summary>
        public const string SHJOBN = "SHJOBN";

        /// <summary>
        /// SHUPMJ.
        /// </summary>
        public const string SHUPMJ = "SHUPMJ";

        /// <summary>
        /// SHTDAY.
        /// </summary>
        public const string SHTDAY = "SHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F45510";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SHSANAME", "SHSANAME", JdeDataType.String, 20, true, true),
        new JdeField("SHSADESC", "SHSADESC", JdeDataType.String, 80),
        new JdeField("SHOMWTBLNM", "SHOMWTBLNM", JdeDataType.String, 22),
        new JdeField("SHSASECUR", "SHSASECUR", JdeDataType.String, 2),
        new JdeField("SHSADIRNB", "SHSADIRNB", JdeDataType.Numeric),
        new JdeField("SHSAMAXVL", "SHSAMAXVL", JdeDataType.Numeric),
        new JdeField("SHSAADDSEL", "SHSAADDSEL", JdeDataType.Numeric),
        new JdeField("SHUSER", "SHUSER", JdeDataType.String, 20),
        new JdeField("SHPID", "SHPID", JdeDataType.String, 20),
        new JdeField("SHJOBN", "SHJOBN", JdeDataType.String, 20),
        new JdeField("SHUPMJ", "SHUPMJ", JdeDataType.Numeric),
        new JdeField("SHTDAY", "SHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F45510_0", "Primary Key on SHSANAME", new[] { "SHSANAME" }, isUnique: true, isPrimaryKey: true)
    };
}
