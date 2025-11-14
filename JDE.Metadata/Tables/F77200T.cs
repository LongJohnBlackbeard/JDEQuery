using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F77200T - .
/// </summary>
public class F77200T : JdeTable
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
        /// J6FORMD.
        /// </summary>
        public const string J6FORMD = "J6FORMD";

        /// <summary>
        /// J6CO.
        /// </summary>
        public const string J6CO = "J6CO";

        /// <summary>
        /// J6AMNDT.
        /// </summary>
        public const string J6AMNDT = "J6AMNDT";

        /// <summary>
        /// J6TARA.
        /// </summary>
        public const string J6TARA = "J6TARA";

        /// <summary>
        /// J6TAXX.
        /// </summary>
        public const string J6TAXX = "J6TAXX";

        /// <summary>
        /// J6ARCS.
        /// </summary>
        public const string J6ARCS = "J6ARCS";

        /// <summary>
        /// J6ACPER.
        /// </summary>
        public const string J6ACPER = "J6ACPER";

        /// <summary>
        /// J6AQPER.
        /// </summary>
        public const string J6AQPER = "J6AQPER";

        /// <summary>
        /// J6AEIPR.
        /// </summary>
        public const string J6AEIPR = "J6AEIPR";

        /// <summary>
        /// J6SPACCA1.
        /// </summary>
        public const string J6SPACCA1 = "J6SPACCA1";

        /// <summary>
        /// J6SPACCA2.
        /// </summary>
        public const string J6SPACCA2 = "J6SPACCA2";

        /// <summary>
        /// J6SPACCA3.
        /// </summary>
        public const string J6SPACCA3 = "J6SPACCA3";

        /// <summary>
        /// J6SPACCA4.
        /// </summary>
        public const string J6SPACCA4 = "J6SPACCA4";

        /// <summary>
        /// J6SPADCA1.
        /// </summary>
        public const string J6SPADCA1 = "J6SPADCA1";

        /// <summary>
        /// J6SPADCA2.
        /// </summary>
        public const string J6SPADCA2 = "J6SPADCA2";

        /// <summary>
        /// J6SPADCA3.
        /// </summary>
        public const string J6SPADCA3 = "J6SPADCA3";

        /// <summary>
        /// J6SPADCA4.
        /// </summary>
        public const string J6SPADCA4 = "J6SPADCA4";

        /// <summary>
        /// J6SPANCA1.
        /// </summary>
        public const string J6SPANCA1 = "J6SPANCA1";

        /// <summary>
        /// J6SPANCA2.
        /// </summary>
        public const string J6SPANCA2 = "J6SPANCA2";

        /// <summary>
        /// J6SPANCA3.
        /// </summary>
        public const string J6SPANCA3 = "J6SPANCA3";

        /// <summary>
        /// J6SPANCA4.
        /// </summary>
        public const string J6SPANCA4 = "J6SPANCA4";

        /// <summary>
        /// J6SPASCA1.
        /// </summary>
        public const string J6SPASCA1 = "J6SPASCA1";

        /// <summary>
        /// J6SPASCA2.
        /// </summary>
        public const string J6SPASCA2 = "J6SPASCA2";

        /// <summary>
        /// J6SPASCA3.
        /// </summary>
        public const string J6SPASCA3 = "J6SPASCA3";

        /// <summary>
        /// J6SPASCA4.
        /// </summary>
        public const string J6SPASCA4 = "J6SPASCA4";

        /// <summary>
        /// J6PID.
        /// </summary>
        public const string J6PID = "J6PID";

        /// <summary>
        /// J6USER.
        /// </summary>
        public const string J6USER = "J6USER";

        /// <summary>
        /// J6JOBN.
        /// </summary>
        public const string J6JOBN = "J6JOBN";

        /// <summary>
        /// J6UPMJ.
        /// </summary>
        public const string J6UPMJ = "J6UPMJ";

        /// <summary>
        /// J6UPMT.
        /// </summary>
        public const string J6UPMT = "J6UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F77200T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J6YEID", "J6YEID", JdeDataType.String, 20, true, true),
        new JdeField("J6TAXYR", "J6TAXYR", JdeDataType.Numeric, null, true, true),
        new JdeField("J6AN8", "J6AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("J6FORMSID", "J6FORMSID", JdeDataType.Numeric, null, true, true),
        new JdeField("J6FORMD", "J6FORMD", JdeDataType.String, 80),
        new JdeField("J6CO", "J6CO", JdeDataType.String, 10, true, true),
        new JdeField("J6AMNDT", "J6AMNDT", JdeDataType.String, 2, true, true),
        new JdeField("J6TARA", "J6TARA", JdeDataType.String, 20, true, true),
        new JdeField("J6TAXX", "J6TAXX", JdeDataType.String, 40, true, true),
        new JdeField("J6ARCS", "J6ARCS", JdeDataType.String, 2),
        new JdeField("J6ACPER", "J6ACPER", JdeDataType.Numeric),
        new JdeField("J6AQPER", "J6AQPER", JdeDataType.Numeric),
        new JdeField("J6AEIPR", "J6AEIPR", JdeDataType.Numeric),
        new JdeField("J6SPACCA1", "J6SPACCA1", JdeDataType.String, 2),
        new JdeField("J6SPACCA2", "J6SPACCA2", JdeDataType.String, 2),
        new JdeField("J6SPACCA3", "J6SPACCA3", JdeDataType.String, 2),
        new JdeField("J6SPACCA4", "J6SPACCA4", JdeDataType.String, 2),
        new JdeField("J6SPADCA1", "J6SPADCA1", JdeDataType.Numeric),
        new JdeField("J6SPADCA2", "J6SPADCA2", JdeDataType.Numeric),
        new JdeField("J6SPADCA3", "J6SPADCA3", JdeDataType.Numeric),
        new JdeField("J6SPADCA4", "J6SPADCA4", JdeDataType.Numeric),
        new JdeField("J6SPANCA1", "J6SPANCA1", JdeDataType.Numeric),
        new JdeField("J6SPANCA2", "J6SPANCA2", JdeDataType.Numeric),
        new JdeField("J6SPANCA3", "J6SPANCA3", JdeDataType.Numeric),
        new JdeField("J6SPANCA4", "J6SPANCA4", JdeDataType.Numeric),
        new JdeField("J6SPASCA1", "J6SPASCA1", JdeDataType.String, 80),
        new JdeField("J6SPASCA2", "J6SPASCA2", JdeDataType.String, 80),
        new JdeField("J6SPASCA3", "J6SPASCA3", JdeDataType.String, 80),
        new JdeField("J6SPASCA4", "J6SPASCA4", JdeDataType.String, 80),
        new JdeField("J6PID", "J6PID", JdeDataType.String, 20),
        new JdeField("J6USER", "J6USER", JdeDataType.String, 20),
        new JdeField("J6JOBN", "J6JOBN", JdeDataType.String, 20),
        new JdeField("J6UPMJ", "J6UPMJ", JdeDataType.Numeric),
        new JdeField("J6UPMT", "J6UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F77200T_0", "Primary Key on J6YEID, J6TAXYR, J6AN8, J6FORMSID, J6CO, J6AMNDT, J6TARA, J6TAXX", new[] { "J6YEID", "J6TAXYR", "J6AN8", "J6FORMSID", "J6CO", "J6AMNDT", "J6TARA", "J6TAXX" }, isUnique: true, isPrimaryKey: true)
    };
}
