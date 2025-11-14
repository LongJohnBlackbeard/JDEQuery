using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A4211 - .
/// </summary>
public class F76A4211 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADKCOO.
        /// </summary>
        public const string ADKCOO = "ADKCOO";

        /// <summary>
        /// ADDOCO.
        /// </summary>
        public const string ADDOCO = "ADDOCO";

        /// <summary>
        /// ADDCTO.
        /// </summary>
        public const string ADDCTO = "ADDCTO";

        /// <summary>
        /// ADLNID.
        /// </summary>
        public const string ADLNID = "ADLNID";

        /// <summary>
        /// ADSNLN.
        /// </summary>
        public const string ADSNLN = "ADSNLN";

        /// <summary>
        /// ADFSTRING1.
        /// </summary>
        public const string ADFSTRING1 = "ADFSTRING1";

        /// <summary>
        /// ADFSTRING2.
        /// </summary>
        public const string ADFSTRING2 = "ADFSTRING2";

        /// <summary>
        /// ADFSTRING3.
        /// </summary>
        public const string ADFSTRING3 = "ADFSTRING3";

        /// <summary>
        /// ADFSTRING4.
        /// </summary>
        public const string ADFSTRING4 = "ADFSTRING4";

        /// <summary>
        /// ADFSTRING5.
        /// </summary>
        public const string ADFSTRING5 = "ADFSTRING5";

        /// <summary>
        /// ADFNUMBR1.
        /// </summary>
        public const string ADFNUMBR1 = "ADFNUMBR1";

        /// <summary>
        /// ADFNUMBR2.
        /// </summary>
        public const string ADFNUMBR2 = "ADFNUMBR2";

        /// <summary>
        /// ADFNUMBR3.
        /// </summary>
        public const string ADFNUMBR3 = "ADFNUMBR3";

        /// <summary>
        /// ADFNUMBR4.
        /// </summary>
        public const string ADFNUMBR4 = "ADFNUMBR4";

        /// <summary>
        /// ADFNUMBR5.
        /// </summary>
        public const string ADFNUMBR5 = "ADFNUMBR5";

        /// <summary>
        /// ADFDTE1.
        /// </summary>
        public const string ADFDTE1 = "ADFDTE1";

        /// <summary>
        /// ADFDTE2.
        /// </summary>
        public const string ADFDTE2 = "ADFDTE2";

        /// <summary>
        /// ADFDTE3.
        /// </summary>
        public const string ADFDTE3 = "ADFDTE3";

        /// <summary>
        /// ADFDTE4.
        /// </summary>
        public const string ADFDTE4 = "ADFDTE4";

        /// <summary>
        /// ADFDTE5.
        /// </summary>
        public const string ADFDTE5 = "ADFDTE5";

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
    }

    /// <inheritdoc />
    public override string TableName => "F76A4211";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADKCOO", "ADKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ADDOCO", "ADDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ADDCTO", "ADDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ADLNID", "ADLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ADSNLN", "ADSNLN", JdeDataType.String, 50),
        new JdeField("ADFSTRING1", "ADFSTRING1", JdeDataType.String, 100),
        new JdeField("ADFSTRING2", "ADFSTRING2", JdeDataType.String, 100),
        new JdeField("ADFSTRING3", "ADFSTRING3", JdeDataType.String, 100),
        new JdeField("ADFSTRING4", "ADFSTRING4", JdeDataType.String, 100),
        new JdeField("ADFSTRING5", "ADFSTRING5", JdeDataType.String, 100),
        new JdeField("ADFNUMBR1", "ADFNUMBR1", JdeDataType.Numeric),
        new JdeField("ADFNUMBR2", "ADFNUMBR2", JdeDataType.Numeric),
        new JdeField("ADFNUMBR3", "ADFNUMBR3", JdeDataType.Numeric),
        new JdeField("ADFNUMBR4", "ADFNUMBR4", JdeDataType.Numeric),
        new JdeField("ADFNUMBR5", "ADFNUMBR5", JdeDataType.Numeric),
        new JdeField("ADFDTE1", "ADFDTE1", JdeDataType.Numeric),
        new JdeField("ADFDTE2", "ADFDTE2", JdeDataType.Numeric),
        new JdeField("ADFDTE3", "ADFDTE3", JdeDataType.Numeric),
        new JdeField("ADFDTE4", "ADFDTE4", JdeDataType.Numeric),
        new JdeField("ADFDTE5", "ADFDTE5", JdeDataType.Numeric),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADJOBN", "ADJOBN", JdeDataType.String, 20),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADTDAY", "ADTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A4211_0", "Primary Key on ADKCOO, ADDOCO, ADDCTO, ADLNID", new[] { "ADKCOO", "ADDOCO", "ADDCTO", "ADLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
