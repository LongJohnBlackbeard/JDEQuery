using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B15 - .
/// </summary>
public class F31B15 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDDCCO.
        /// </summary>
        public const string TDDCCO = "TDDCCO";

        /// <summary>
        /// TDMCU.
        /// </summary>
        public const string TDMCU = "TDMCU";

        /// <summary>
        /// TDWTKID.
        /// </summary>
        public const string TDWTKID = "TDWTKID";

        /// <summary>
        /// TDDCDE.
        /// </summary>
        public const string TDDCDE = "TDDCDE";

        /// <summary>
        /// TDDCSTA.
        /// </summary>
        public const string TDDCSTA = "TDDCSTA";

        /// <summary>
        /// TDTMST.
        /// </summary>
        public const string TDTMST = "TDTMST";

        /// <summary>
        /// TDTKGT.
        /// </summary>
        public const string TDTKGT = "TDTKGT";

        /// <summary>
        /// TDTDMN.
        /// </summary>
        public const string TDTDMN = "TDTDMN";

        /// <summary>
        /// TDTDMX.
        /// </summary>
        public const string TDTDMX = "TDTDMX";

        /// <summary>
        /// TDTDIV.
        /// </summary>
        public const string TDTDIV = "TDTDIV";

        /// <summary>
        /// TDDDUM.
        /// </summary>
        public const string TDDDUM = "TDDDUM";

        /// <summary>
        /// TDDPVA.
        /// </summary>
        public const string TDDPVA = "TDDPVA";

        /// <summary>
        /// TDURCD.
        /// </summary>
        public const string TDURCD = "TDURCD";

        /// <summary>
        /// TDURDT.
        /// </summary>
        public const string TDURDT = "TDURDT";

        /// <summary>
        /// TDURAT.
        /// </summary>
        public const string TDURAT = "TDURAT";

        /// <summary>
        /// TDURAB.
        /// </summary>
        public const string TDURAB = "TDURAB";

        /// <summary>
        /// TDURRF.
        /// </summary>
        public const string TDURRF = "TDURRF";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDUPMT.
        /// </summary>
        public const string TDUPMT = "TDUPMT";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDJOBN.
        /// </summary>
        public const string TDJOBN = "TDJOBN";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDTDMN1.
        /// </summary>
        public const string TDTDMN1 = "TDTDMN1";

        /// <summary>
        /// TDTDMN2.
        /// </summary>
        public const string TDTDMN2 = "TDTDMN2";

        /// <summary>
        /// TDTDMN3.
        /// </summary>
        public const string TDTDMN3 = "TDTDMN3";

        /// <summary>
        /// TDTDMX1.
        /// </summary>
        public const string TDTDMX1 = "TDTDMX1";

        /// <summary>
        /// TDTDMX2.
        /// </summary>
        public const string TDTDMX2 = "TDTDMX2";

        /// <summary>
        /// TDTDMX3.
        /// </summary>
        public const string TDTDMX3 = "TDTDMX3";

        /// <summary>
        /// TDTDMNM.
        /// </summary>
        public const string TDTDMNM = "TDTDMNM";

        /// <summary>
        /// TDTDMXM.
        /// </summary>
        public const string TDTDMXM = "TDTDMXM";
    }

    /// <inheritdoc />
    public override string TableName => "F31B15";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDDCCO", "TDDCCO", JdeDataType.String, 16, true, true),
        new JdeField("TDMCU", "TDMCU", JdeDataType.String, 24, true, true),
        new JdeField("TDWTKID", "TDWTKID", JdeDataType.Numeric),
        new JdeField("TDDCDE", "TDDCDE", JdeDataType.String, 60),
        new JdeField("TDDCSTA", "TDDCSTA", JdeDataType.String, 2),
        new JdeField("TDTMST", "TDTMST", JdeDataType.String, 2),
        new JdeField("TDTKGT", "TDTKGT", JdeDataType.String, 2),
        new JdeField("TDTDMN", "TDTDMN", JdeDataType.Numeric),
        new JdeField("TDTDMX", "TDTDMX", JdeDataType.Numeric),
        new JdeField("TDTDIV", "TDTDIV", JdeDataType.Numeric),
        new JdeField("TDDDUM", "TDDDUM", JdeDataType.String, 4),
        new JdeField("TDDPVA", "TDDPVA", JdeDataType.Numeric),
        new JdeField("TDURCD", "TDURCD", JdeDataType.String, 4),
        new JdeField("TDURDT", "TDURDT", JdeDataType.Numeric),
        new JdeField("TDURAT", "TDURAT", JdeDataType.Numeric),
        new JdeField("TDURAB", "TDURAB", JdeDataType.Numeric),
        new JdeField("TDURRF", "TDURRF", JdeDataType.String, 30),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDUPMT", "TDUPMT", JdeDataType.Numeric),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDTDMN1", "TDTDMN1", JdeDataType.Numeric),
        new JdeField("TDTDMN2", "TDTDMN2", JdeDataType.Numeric),
        new JdeField("TDTDMN3", "TDTDMN3", JdeDataType.Numeric),
        new JdeField("TDTDMX1", "TDTDMX1", JdeDataType.Numeric),
        new JdeField("TDTDMX2", "TDTDMX2", JdeDataType.Numeric),
        new JdeField("TDTDMX3", "TDTDMX3", JdeDataType.Numeric),
        new JdeField("TDTDMNM", "TDTDMNM", JdeDataType.Numeric),
        new JdeField("TDTDMXM", "TDTDMXM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B15_0", "Primary Key on TDDCCO, TDMCU", new[] { "TDDCCO", "TDMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B15_2", "Index on TDDCCO", new[] { "TDDCCO" })
    };
}
