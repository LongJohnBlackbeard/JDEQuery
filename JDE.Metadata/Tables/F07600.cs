using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07600 - .
/// </summary>
public class F07600 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCCO.
        /// </summary>
        public const string LCCO = "LCCO";

        /// <summary>
        /// LCFMMA.
        /// </summary>
        public const string LCFMMA = "LCFMMA";

        /// <summary>
        /// LCAVBL.
        /// </summary>
        public const string LCAVBL = "LCAVBL";

        /// <summary>
        /// LCACBL.
        /// </summary>
        public const string LCACBL = "LCACBL";

        /// <summary>
        /// LCSKBL.
        /// </summary>
        public const string LCSKBL = "LCSKBL";

        /// <summary>
        /// LCLVDC.
        /// </summary>
        public const string LCLVDC = "LCLVDC";

        /// <summary>
        /// LCLVFB.
        /// </summary>
        public const string LCLVFB = "LCLVFB";

        /// <summary>
        /// LCLVFE.
        /// </summary>
        public const string LCLVFE = "LCLVFE";

        /// <summary>
        /// LCLVAM.
        /// </summary>
        public const string LCLVAM = "LCLVAM";

        /// <summary>
        /// LCLVSX.
        /// </summary>
        public const string LCLVSX = "LCLVSX";

        /// <summary>
        /// LCLVEN.
        /// </summary>
        public const string LCLVEN = "LCLVEN";

        /// <summary>
        /// LCMLSV.
        /// </summary>
        public const string LCMLSV = "LCMLSV";

        /// <summary>
        /// LCMLHW.
        /// </summary>
        public const string LCMLHW = "LCMLHW";

        /// <summary>
        /// LCTCCR.
        /// </summary>
        public const string LCTCCR = "LCTCCR";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCJOBN.
        /// </summary>
        public const string LCJOBN = "LCJOBN";

        /// <summary>
        /// LCUPMJ.
        /// </summary>
        public const string LCUPMJ = "LCUPMJ";

        /// <summary>
        /// LCUPMT.
        /// </summary>
        public const string LCUPMT = "LCUPMT";

        /// <summary>
        /// LCUSVH.
        /// </summary>
        public const string LCUSVH = "LCUSVH";

        /// <summary>
        /// LCLVESS.
        /// </summary>
        public const string LCLVESS = "LCLVESS";
    }

    /// <inheritdoc />
    public override string TableName => "F07600";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCCO", "LCCO", JdeDataType.String, 10, true, true),
        new JdeField("LCFMMA", "LCFMMA", JdeDataType.String, 2),
        new JdeField("LCAVBL", "LCAVBL", JdeDataType.String, 2),
        new JdeField("LCACBL", "LCACBL", JdeDataType.String, 2),
        new JdeField("LCSKBL", "LCSKBL", JdeDataType.String, 2),
        new JdeField("LCLVDC", "LCLVDC", JdeDataType.String, 2),
        new JdeField("LCLVFB", "LCLVFB", JdeDataType.Numeric),
        new JdeField("LCLVFE", "LCLVFE", JdeDataType.Numeric),
        new JdeField("LCLVAM", "LCLVAM", JdeDataType.Numeric),
        new JdeField("LCLVSX", "LCLVSX", JdeDataType.String, 2),
        new JdeField("LCLVEN", "LCLVEN", JdeDataType.String, 2),
        new JdeField("LCMLSV", "LCMLSV", JdeDataType.Numeric),
        new JdeField("LCMLHW", "LCMLHW", JdeDataType.Numeric),
        new JdeField("LCTCCR", "LCTCCR", JdeDataType.String, 2),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCJOBN", "LCJOBN", JdeDataType.String, 20),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric),
        new JdeField("LCUPMT", "LCUPMT", JdeDataType.Numeric),
        new JdeField("LCUSVH", "LCUSVH", JdeDataType.String, 2),
        new JdeField("LCLVESS", "LCLVESS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07600_0", "Primary Key on LCCO", new[] { "LCCO" }, isUnique: true, isPrimaryKey: true)
    };
}
