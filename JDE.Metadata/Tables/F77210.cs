using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F77210 - .
/// </summary>
public class F77210 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J6YEID.
        /// </summary>
        public const string J6YEID = "J6YEID";

        /// <summary>
        /// J6TAXYR.
        /// </summary>
        public const string J6TAXYR = "J6TAXYR";

        /// <summary>
        /// J6AN8.
        /// </summary>
        public const string J6AN8 = "J6AN8";

        /// <summary>
        /// J6FORMSID.
        /// </summary>
        public const string J6FORMSID = "J6FORMSID";

        /// <summary>
        /// J6CO.
        /// </summary>
        public const string J6CO = "J6CO";

        /// <summary>
        /// J6AMNDT.
        /// </summary>
        public const string J6AMNDT = "J6AMNDT";

        /// <summary>
        /// J6TAXX.
        /// </summary>
        public const string J6TAXX = "J6TAXX";

        /// <summary>
        /// J6TARA.
        /// </summary>
        public const string J6TARA = "J6TARA";

        /// <summary>
        /// J6BOXN.
        /// </summary>
        public const string J6BOXN = "J6BOXN";

        /// <summary>
        /// J6AMNT.
        /// </summary>
        public const string J6AMNT = "J6AMNT";

        /// <summary>
        /// J6AMTADJ.
        /// </summary>
        public const string J6AMTADJ = "J6AMTADJ";

        /// <summary>
        /// J6ATEXT.
        /// </summary>
        public const string J6ATEXT = "J6ATEXT";

        /// <summary>
        /// J6ARCS.
        /// </summary>
        public const string J6ARCS = "J6ARCS";

        /// <summary>
        /// J6UPMJ.
        /// </summary>
        public const string J6UPMJ = "J6UPMJ";

        /// <summary>
        /// J6UPMT.
        /// </summary>
        public const string J6UPMT = "J6UPMT";

        /// <summary>
        /// J6PID.
        /// </summary>
        public const string J6PID = "J6PID";

        /// <summary>
        /// J6JOBN.
        /// </summary>
        public const string J6JOBN = "J6JOBN";

        /// <summary>
        /// J6USER.
        /// </summary>
        public const string J6USER = "J6USER";
    }

    /// <inheritdoc />
    public override string TableName => "F77210";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J6YEID", "J6YEID", JdeDataType.String, 20, true, true),
        new JdeField("J6TAXYR", "J6TAXYR", JdeDataType.Numeric, null, true, true),
        new JdeField("J6AN8", "J6AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("J6FORMSID", "J6FORMSID", JdeDataType.Numeric, null, true, true),
        new JdeField("J6CO", "J6CO", JdeDataType.String, 10, true, true),
        new JdeField("J6AMNDT", "J6AMNDT", JdeDataType.String, 2, true, true),
        new JdeField("J6TAXX", "J6TAXX", JdeDataType.String, 40, true, true),
        new JdeField("J6TARA", "J6TARA", JdeDataType.String, 20, true, true),
        new JdeField("J6BOXN", "J6BOXN", JdeDataType.String, 20, true, true),
        new JdeField("J6AMNT", "J6AMNT", JdeDataType.Numeric),
        new JdeField("J6AMTADJ", "J6AMTADJ", JdeDataType.Numeric),
        new JdeField("J6ATEXT", "J6ATEXT", JdeDataType.String, 80),
        new JdeField("J6ARCS", "J6ARCS", JdeDataType.String, 2),
        new JdeField("J6UPMJ", "J6UPMJ", JdeDataType.Numeric),
        new JdeField("J6UPMT", "J6UPMT", JdeDataType.Numeric),
        new JdeField("J6PID", "J6PID", JdeDataType.String, 20),
        new JdeField("J6JOBN", "J6JOBN", JdeDataType.String, 20),
        new JdeField("J6USER", "J6USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F77210_0", "Primary Key on J6YEID, J6TAXYR, J6AN8, J6FORMSID, J6CO, J6AMNDT, J6TAXX, J6TARA, J6BOXN", new[] { "J6YEID", "J6TAXYR", "J6AN8", "J6FORMSID", "J6CO", "J6AMNDT", "J6TAXX", "J6TARA", "J6BOXN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F77210_2", "Index on J6YEID, J6TAXYR, J6FORMSID", new[] { "J6YEID", "J6TAXYR", "J6FORMSID" }),
        new JdeIndex("F77210_4", "Index on J6YEID, J6TAXYR", new[] { "J6YEID", "J6TAXYR" })
    };
}
