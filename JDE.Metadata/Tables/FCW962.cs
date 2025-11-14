using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW962 - .
/// </summary>
public class FCW962 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CLJOBS.
        /// </summary>
        public const string CLJOBS = "CLJOBS";

        /// <summary>
        /// CLCPIT.
        /// </summary>
        public const string CLCPIT = "CLCPIT";

        /// <summary>
        /// CLCPIL.
        /// </summary>
        public const string CLCPIL = "CLCPIL";

        /// <summary>
        /// CLCPIA.
        /// </summary>
        public const string CLCPIA = "CLCPIA";

        /// <summary>
        /// CLCMCU.
        /// </summary>
        public const string CLCMCU = "CLCMCU";

        /// <summary>
        /// CLMCUZ.
        /// </summary>
        public const string CLMCUZ = "CLMCUZ";

        /// <summary>
        /// CLDSC1.
        /// </summary>
        public const string CLDSC1 = "CLDSC1";

        /// <summary>
        /// CLUOM1.
        /// </summary>
        public const string CLUOM1 = "CLUOM1";

        /// <summary>
        /// CLUORG.
        /// </summary>
        public const string CLUORG = "CLUORG";

        /// <summary>
        /// CLPCOM.
        /// </summary>
        public const string CLPCOM = "CLPCOM";

        /// <summary>
        /// CLQAVAL.
        /// </summary>
        public const string CLQAVAL = "CLQAVAL";

        /// <summary>
        /// CLQROUT.
        /// </summary>
        public const string CLQROUT = "CLQROUT";

        /// <summary>
        /// CLPREQ.
        /// </summary>
        public const string CLPREQ = "CLPREQ";

        /// <summary>
        /// CLRSCP.
        /// </summary>
        public const string CLRSCP = "CLRSCP";

        /// <summary>
        /// CLCKAV.
        /// </summary>
        public const string CLCKAV = "CLCKAV";

        /// <summary>
        /// CLUSER.
        /// </summary>
        public const string CLUSER = "CLUSER";

        /// <summary>
        /// CLPID.
        /// </summary>
        public const string CLPID = "CLPID";

        /// <summary>
        /// CLJOBN.
        /// </summary>
        public const string CLJOBN = "CLJOBN";

        /// <summary>
        /// CLUPMJ.
        /// </summary>
        public const string CLUPMJ = "CLUPMJ";

        /// <summary>
        /// CLUPMT.
        /// </summary>
        public const string CLUPMT = "CLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FCW962";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CLJOBS", "CLJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CLCPIT", "CLCPIT", JdeDataType.Numeric, null, true, true),
        new JdeField("CLCPIL", "CLCPIL", JdeDataType.String, 50),
        new JdeField("CLCPIA", "CLCPIA", JdeDataType.String, 50),
        new JdeField("CLCMCU", "CLCMCU", JdeDataType.String, 24, true, true),
        new JdeField("CLMCUZ", "CLMCUZ", JdeDataType.String, 24),
        new JdeField("CLDSC1", "CLDSC1", JdeDataType.String, 60),
        new JdeField("CLUOM1", "CLUOM1", JdeDataType.String, 4),
        new JdeField("CLUORG", "CLUORG", JdeDataType.Numeric),
        new JdeField("CLPCOM", "CLPCOM", JdeDataType.Numeric),
        new JdeField("CLQAVAL", "CLQAVAL", JdeDataType.Numeric),
        new JdeField("CLQROUT", "CLQROUT", JdeDataType.Numeric),
        new JdeField("CLPREQ", "CLPREQ", JdeDataType.Numeric),
        new JdeField("CLRSCP", "CLRSCP", JdeDataType.Numeric),
        new JdeField("CLCKAV", "CLCKAV", JdeDataType.String, 2),
        new JdeField("CLUSER", "CLUSER", JdeDataType.String, 20),
        new JdeField("CLPID", "CLPID", JdeDataType.String, 20),
        new JdeField("CLJOBN", "CLJOBN", JdeDataType.String, 20),
        new JdeField("CLUPMJ", "CLUPMJ", JdeDataType.Numeric),
        new JdeField("CLUPMT", "CLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW962_0", "Primary Key on CLJOBS, CLCPIT, CLCMCU", new[] { "CLJOBS", "CLCPIT", "CLCMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
