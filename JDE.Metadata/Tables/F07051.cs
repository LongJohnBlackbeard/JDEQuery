using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07051 - .
/// </summary>
public class F07051 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JVVCKC.
        /// </summary>
        public const string JVVCKC = "JVVCKC";

        /// <summary>
        /// JVAN8.
        /// </summary>
        public const string JVAN8 = "JVAN8";

        /// <summary>
        /// JVPDBA.
        /// </summary>
        public const string JVPDBA = "JVPDBA";

        /// <summary>
        /// JVWANO.
        /// </summary>
        public const string JVWANO = "JVWANO";

        /// <summary>
        /// JVDTEY.
        /// </summary>
        public const string JVDTEY = "JVDTEY";

        /// <summary>
        /// JVHMO.
        /// </summary>
        public const string JVHMO = "JVHMO";

        /// <summary>
        /// JVPPP.
        /// </summary>
        public const string JVPPP = "JVPPP";

        /// <summary>
        /// JVTAXX.
        /// </summary>
        public const string JVTAXX = "JVTAXX";

        /// <summary>
        /// JVHMCO.
        /// </summary>
        public const string JVHMCO = "JVHMCO";

        /// <summary>
        /// JVGPA.
        /// </summary>
        public const string JVGPA = "JVGPA";

        /// <summary>
        /// JVCKCN.
        /// </summary>
        public const string JVCKCN = "JVCKCN";

        /// <summary>
        /// JVRTAM.
        /// </summary>
        public const string JVRTAM = "JVRTAM";

        /// <summary>
        /// JVPID.
        /// </summary>
        public const string JVPID = "JVPID";

        /// <summary>
        /// JVUSER.
        /// </summary>
        public const string JVUSER = "JVUSER";

        /// <summary>
        /// JVUPMJ.
        /// </summary>
        public const string JVUPMJ = "JVUPMJ";

        /// <summary>
        /// JVUPMT.
        /// </summary>
        public const string JVUPMT = "JVUPMT";

        /// <summary>
        /// JVJOBN.
        /// </summary>
        public const string JVJOBN = "JVJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F07051";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JVVCKC", "JVVCKC", JdeDataType.Numeric, null, true, true),
        new JdeField("JVAN8", "JVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JVPDBA", "JVPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("JVWANO", "JVWANO", JdeDataType.Numeric, null, true, true),
        new JdeField("JVDTEY", "JVDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("JVHMO", "JVHMO", JdeDataType.Numeric, null, true, true),
        new JdeField("JVPPP", "JVPPP", JdeDataType.String, 2, true, true),
        new JdeField("JVTAXX", "JVTAXX", JdeDataType.String, 40, true, true),
        new JdeField("JVHMCO", "JVHMCO", JdeDataType.String, 10, true, true),
        new JdeField("JVGPA", "JVGPA", JdeDataType.Numeric),
        new JdeField("JVCKCN", "JVCKCN", JdeDataType.Numeric),
        new JdeField("JVRTAM", "JVRTAM", JdeDataType.Numeric),
        new JdeField("JVPID", "JVPID", JdeDataType.String, 20),
        new JdeField("JVUSER", "JVUSER", JdeDataType.String, 20),
        new JdeField("JVUPMJ", "JVUPMJ", JdeDataType.Numeric),
        new JdeField("JVUPMT", "JVUPMT", JdeDataType.Numeric),
        new JdeField("JVJOBN", "JVJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07051_0", "Primary Key on JVVCKC, JVAN8, JVPDBA, JVWANO, JVDTEY, JVHMO, JVPPP, JVTAXX, JVHMCO", new[] { "JVVCKC", "JVAN8", "JVPDBA", "JVWANO", "JVDTEY", "JVHMO", "JVPPP", "JVTAXX", "JVHMCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07051_2", "Index on JVCKCN, JVAN8, JVPDBA, JVWANO", new[] { "JVCKCN", "JVAN8", "JVPDBA", "JVWANO" })
    };
}
