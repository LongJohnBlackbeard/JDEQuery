using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F740006T - .
/// </summary>
public class F740006T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDKCO.
        /// </summary>
        public const string LDKCO = "LDKCO";

        /// <summary>
        /// LDDCT.
        /// </summary>
        public const string LDDCT = "LDDCT";

        /// <summary>
        /// LDDOC.
        /// </summary>
        public const string LDDOC = "LDDOC";

        /// <summary>
        /// LDK74FLEN.
        /// </summary>
        public const string LDK74FLEN = "LDK74FLEN";

        /// <summary>
        /// LDK74LDDJ.
        /// </summary>
        public const string LDK74LDDJ = "LDK74LDDJ";

        /// <summary>
        /// LDK74INVST.
        /// </summary>
        public const string LDK74INVST = "LDK74INVST";

        /// <summary>
        /// LDVOD.
        /// </summary>
        public const string LDVOD = "LDVOD";

        /// <summary>
        /// LDK74MSG1.
        /// </summary>
        public const string LDK74MSG1 = "LDK74MSG1";

        /// <summary>
        /// LDK74MSG2.
        /// </summary>
        public const string LDK74MSG2 = "LDK74MSG2";

        /// <summary>
        /// LDK74MSG3.
        /// </summary>
        public const string LDK74MSG3 = "LDK74MSG3";

        /// <summary>
        /// LDK74RSCD.
        /// </summary>
        public const string LDK74RSCD = "LDK74RSCD";

        /// <summary>
        /// LDEFTJ.
        /// </summary>
        public const string LDEFTJ = "LDEFTJ";

        /// <summary>
        /// LDK74RECD.
        /// </summary>
        public const string LDK74RECD = "LDK74RECD";

        /// <summary>
        /// LDUSER.
        /// </summary>
        public const string LDUSER = "LDUSER";

        /// <summary>
        /// LDPID.
        /// </summary>
        public const string LDPID = "LDPID";

        /// <summary>
        /// LDJOBN.
        /// </summary>
        public const string LDJOBN = "LDJOBN";

        /// <summary>
        /// LDUPMJ.
        /// </summary>
        public const string LDUPMJ = "LDUPMJ";

        /// <summary>
        /// LDUPMT.
        /// </summary>
        public const string LDUPMT = "LDUPMT";

        /// <summary>
        /// LDYFUTDT.
        /// </summary>
        public const string LDYFUTDT = "LDYFUTDT";

        /// <summary>
        /// LDFFU4.
        /// </summary>
        public const string LDFFU4 = "LDFFU4";

        /// <summary>
        /// LDFUT3.
        /// </summary>
        public const string LDFUT3 = "LDFUT3";

        /// <summary>
        /// LDX2.
        /// </summary>
        public const string LDX2 = "LDX2";

        /// <summary>
        /// LDFUTCH1.
        /// </summary>
        public const string LDFUTCH1 = "LDFUTCH1";

        /// <summary>
        /// LDK74CNDT.
        /// </summary>
        public const string LDK74CNDT = "LDK74CNDT";

        /// <summary>
        /// LDK74CNFLG.
        /// </summary>
        public const string LDK74CNFLG = "LDK74CNFLG";
    }

    /// <inheritdoc />
    public override string TableName => "F740006T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDKCO", "LDKCO", JdeDataType.String, 10, true, true),
        new JdeField("LDDCT", "LDDCT", JdeDataType.String, 4, true, true),
        new JdeField("LDDOC", "LDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("LDK74FLEN", "LDK74FLEN", JdeDataType.String, 50),
        new JdeField("LDK74LDDJ", "LDK74LDDJ", JdeDataType.Numeric),
        new JdeField("LDK74INVST", "LDK74INVST", JdeDataType.String, 4),
        new JdeField("LDVOD", "LDVOD", JdeDataType.String, 2),
        new JdeField("LDK74MSG1", "LDK74MSG1", JdeDataType.String, 2048),
        new JdeField("LDK74MSG2", "LDK74MSG2", JdeDataType.String, 2048),
        new JdeField("LDK74MSG3", "LDK74MSG3", JdeDataType.String, 2048),
        new JdeField("LDK74RSCD", "LDK74RSCD", JdeDataType.String, 20),
        new JdeField("LDEFTJ", "LDEFTJ", JdeDataType.Numeric),
        new JdeField("LDK74RECD", "LDK74RECD", JdeDataType.String, 1000),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20),
        new JdeField("LDJOBN", "LDJOBN", JdeDataType.String, 20),
        new JdeField("LDUPMJ", "LDUPMJ", JdeDataType.Numeric),
        new JdeField("LDUPMT", "LDUPMT", JdeDataType.Numeric),
        new JdeField("LDYFUTDT", "LDYFUTDT", JdeDataType.Numeric),
        new JdeField("LDFFU4", "LDFFU4", JdeDataType.Numeric),
        new JdeField("LDFUT3", "LDFUT3", JdeDataType.String, 60),
        new JdeField("LDX2", "LDX2", JdeDataType.String, 2),
        new JdeField("LDFUTCH1", "LDFUTCH1", JdeDataType.String, 2),
        new JdeField("LDK74CNDT", "LDK74CNDT", JdeDataType.Numeric),
        new JdeField("LDK74CNFLG", "LDK74CNFLG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F740006T_0", "Primary Key on LDKCO, LDDCT, LDDOC", new[] { "LDKCO", "LDDCT", "LDDOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F740006T_2", "Index on LDKCO, LDK74FLEN, LDK74LDDJ", new[] { "LDKCO", "LDK74FLEN", "LDK74LDDJ" })
    };
}
