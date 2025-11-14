using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47800 - .
/// </summary>
public class F47800 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FFEDTY.
        /// </summary>
        public const string FFEDTY = "FFEDTY";

        /// <summary>
        /// FFEKCO.
        /// </summary>
        public const string FFEKCO = "FFEKCO";

        /// <summary>
        /// FFEDOC.
        /// </summary>
        public const string FFEDOC = "FFEDOC";

        /// <summary>
        /// FFEDCT.
        /// </summary>
        public const string FFEDCT = "FFEDCT";

        /// <summary>
        /// FFEDST.
        /// </summary>
        public const string FFEDST = "FFEDST";

        /// <summary>
        /// FFEDFT.
        /// </summary>
        public const string FFEDFT = "FFEDFT";

        /// <summary>
        /// FFEDDT.
        /// </summary>
        public const string FFEDDT = "FFEDDT";

        /// <summary>
        /// FFEDER.
        /// </summary>
        public const string FFEDER = "FFEDER";

        /// <summary>
        /// FFEDDL.
        /// </summary>
        public const string FFEDDL = "FFEDDL";

        /// <summary>
        /// FFEDSP.
        /// </summary>
        public const string FFEDSP = "FFEDSP";

        /// <summary>
        /// FFEDBT.
        /// </summary>
        public const string FFEDBT = "FFEDBT";

        /// <summary>
        /// FFEDITM.
        /// </summary>
        public const string FFEDITM = "FFEDITM";

        /// <summary>
        /// FFTBLE.
        /// </summary>
        public const string FFTBLE = "FFTBLE";

        /// <summary>
        /// FFURCD.
        /// </summary>
        public const string FFURCD = "FFURCD";

        /// <summary>
        /// FFURDT.
        /// </summary>
        public const string FFURDT = "FFURDT";

        /// <summary>
        /// FFURAT.
        /// </summary>
        public const string FFURAT = "FFURAT";

        /// <summary>
        /// FFURAB.
        /// </summary>
        public const string FFURAB = "FFURAB";

        /// <summary>
        /// FFURRF.
        /// </summary>
        public const string FFURRF = "FFURRF";

        /// <summary>
        /// FFUSER.
        /// </summary>
        public const string FFUSER = "FFUSER";

        /// <summary>
        /// FFPID.
        /// </summary>
        public const string FFPID = "FFPID";

        /// <summary>
        /// FFJOBN.
        /// </summary>
        public const string FFJOBN = "FFJOBN";

        /// <summary>
        /// FFUPMJ.
        /// </summary>
        public const string FFUPMJ = "FFUPMJ";

        /// <summary>
        /// FFTDAY.
        /// </summary>
        public const string FFTDAY = "FFTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F47800";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FFEDTY", "FFEDTY", JdeDataType.String, 2),
        new JdeField("FFEKCO", "FFEKCO", JdeDataType.String, 10, true, true),
        new JdeField("FFEDOC", "FFEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("FFEDCT", "FFEDCT", JdeDataType.String, 4, true, true),
        new JdeField("FFEDST", "FFEDST", JdeDataType.String, 12),
        new JdeField("FFEDFT", "FFEDFT", JdeDataType.String, 20),
        new JdeField("FFEDDT", "FFEDDT", JdeDataType.Numeric),
        new JdeField("FFEDER", "FFEDER", JdeDataType.String, 2),
        new JdeField("FFEDDL", "FFEDDL", JdeDataType.Numeric),
        new JdeField("FFEDSP", "FFEDSP", JdeDataType.String, 2),
        new JdeField("FFEDBT", "FFEDBT", JdeDataType.String, 30),
        new JdeField("FFEDITM", "FFEDITM", JdeDataType.Numeric),
        new JdeField("FFTBLE", "FFTBLE", JdeDataType.String, 60),
        new JdeField("FFURCD", "FFURCD", JdeDataType.String, 4),
        new JdeField("FFURDT", "FFURDT", JdeDataType.Numeric),
        new JdeField("FFURAT", "FFURAT", JdeDataType.Numeric),
        new JdeField("FFURAB", "FFURAB", JdeDataType.Numeric),
        new JdeField("FFURRF", "FFURRF", JdeDataType.String, 30),
        new JdeField("FFUSER", "FFUSER", JdeDataType.String, 20),
        new JdeField("FFPID", "FFPID", JdeDataType.String, 20),
        new JdeField("FFJOBN", "FFJOBN", JdeDataType.String, 20),
        new JdeField("FFUPMJ", "FFUPMJ", JdeDataType.Numeric),
        new JdeField("FFTDAY", "FFTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47800_0", "Primary Key on FFEDOC, FFEDCT, FFEKCO", new[] { "FFEDOC", "FFEDCT", "FFEKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
