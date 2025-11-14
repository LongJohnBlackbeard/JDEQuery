using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48316 - .
/// </summary>
public class F48316 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RSDOCO.
        /// </summary>
        public const string RSDOCO = "RSDOCO";

        /// <summary>
        /// RSOPSQ.
        /// </summary>
        public const string RSOPSQ = "RSOPSQ";

        /// <summary>
        /// RSOPSC.
        /// </summary>
        public const string RSOPSC = "RSOPSC";

        /// <summary>
        /// RSMCU.
        /// </summary>
        public const string RSMCU = "RSMCU";

        /// <summary>
        /// RSSESD.
        /// </summary>
        public const string RSSESD = "RSSESD";

        /// <summary>
        /// RSSHFT.
        /// </summary>
        public const string RSSHFT = "RSSHFT";

        /// <summary>
        /// RSWRSCHC.
        /// </summary>
        public const string RSWRSCHC = "RSWRSCHC";

        /// <summary>
        /// RSANSA.
        /// </summary>
        public const string RSANSA = "RSANSA";

        /// <summary>
        /// RSANPA.
        /// </summary>
        public const string RSANPA = "RSANPA";

        /// <summary>
        /// RSRRTY.
        /// </summary>
        public const string RSRRTY = "RSRRTY";

        /// <summary>
        /// RSRSCN.
        /// </summary>
        public const string RSRSCN = "RSRSCN";

        /// <summary>
        /// RSDSC1.
        /// </summary>
        public const string RSDSC1 = "RSDSC1";

        /// <summary>
        /// RSDSC2.
        /// </summary>
        public const string RSDSC2 = "RSDSC2";

        /// <summary>
        /// RSCRTU.
        /// </summary>
        public const string RSCRTU = "RSCRTU";

        /// <summary>
        /// RSURAB.
        /// </summary>
        public const string RSURAB = "RSURAB";

        /// <summary>
        /// RSURAT.
        /// </summary>
        public const string RSURAT = "RSURAT";

        /// <summary>
        /// RSURCD.
        /// </summary>
        public const string RSURCD = "RSURCD";

        /// <summary>
        /// RSURDT.
        /// </summary>
        public const string RSURDT = "RSURDT";

        /// <summary>
        /// RSURRF.
        /// </summary>
        public const string RSURRF = "RSURRF";

        /// <summary>
        /// RSUSER.
        /// </summary>
        public const string RSUSER = "RSUSER";

        /// <summary>
        /// RSMKEY.
        /// </summary>
        public const string RSMKEY = "RSMKEY";

        /// <summary>
        /// RSUPMJ.
        /// </summary>
        public const string RSUPMJ = "RSUPMJ";

        /// <summary>
        /// RSUPMT.
        /// </summary>
        public const string RSUPMT = "RSUPMT";

        /// <summary>
        /// RSPID.
        /// </summary>
        public const string RSPID = "RSPID";
    }

    /// <inheritdoc />
    public override string TableName => "F48316";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RSDOCO", "RSDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RSOPSQ", "RSOPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RSOPSC", "RSOPSC", JdeDataType.String, 4, true, true),
        new JdeField("RSMCU", "RSMCU", JdeDataType.String, 24, true, true),
        new JdeField("RSSESD", "RSSESD", JdeDataType.Numeric, null, true, true),
        new JdeField("RSSHFT", "RSSHFT", JdeDataType.String, 2, true, true),
        new JdeField("RSWRSCHC", "RSWRSCHC", JdeDataType.String, 6),
        new JdeField("RSANSA", "RSANSA", JdeDataType.Numeric),
        new JdeField("RSANPA", "RSANPA", JdeDataType.Numeric),
        new JdeField("RSRRTY", "RSRRTY", JdeDataType.String, 4),
        new JdeField("RSRSCN", "RSRSCN", JdeDataType.Numeric),
        new JdeField("RSDSC1", "RSDSC1", JdeDataType.String, 60),
        new JdeField("RSDSC2", "RSDSC2", JdeDataType.String, 60),
        new JdeField("RSCRTU", "RSCRTU", JdeDataType.String, 20),
        new JdeField("RSURAB", "RSURAB", JdeDataType.Numeric),
        new JdeField("RSURAT", "RSURAT", JdeDataType.Numeric),
        new JdeField("RSURCD", "RSURCD", JdeDataType.String, 4),
        new JdeField("RSURDT", "RSURDT", JdeDataType.Numeric),
        new JdeField("RSURRF", "RSURRF", JdeDataType.String, 30),
        new JdeField("RSUSER", "RSUSER", JdeDataType.String, 20),
        new JdeField("RSMKEY", "RSMKEY", JdeDataType.String, 30),
        new JdeField("RSUPMJ", "RSUPMJ", JdeDataType.Numeric),
        new JdeField("RSUPMT", "RSUPMT", JdeDataType.Numeric),
        new JdeField("RSPID", "RSPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48316_0", "Primary Key on RSDOCO, RSOPSQ, RSOPSC, RSMCU, RSSESD, RSSHFT", new[] { "RSDOCO", "RSOPSQ", "RSOPSC", "RSMCU", "RSSESD", "RSSHFT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48316_2", "Index on RSANSA, RSANPA, RSSESD, RSSHFT", new[] { "RSANSA", "RSANPA", "RSSESD", "RSSHFT" })
    };
}
