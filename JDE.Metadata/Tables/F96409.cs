using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F96409 - .
/// </summary>
public class F96409 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EMESUP.
        /// </summary>
        public const string EMESUP = "EMESUP";

        /// <summary>
        /// EMSUTYPE.
        /// </summary>
        public const string EMSUTYPE = "EMSUTYPE";

        /// <summary>
        /// EMHOSTTYPE.
        /// </summary>
        public const string EMHOSTTYPE = "EMHOSTTYPE";

        /// <summary>
        /// EMSUEMAIL.
        /// </summary>
        public const string EMSUEMAIL = "EMSUEMAIL";

        /// <summary>
        /// EMSUEMACTV.
        /// </summary>
        public const string EMSUEMACTV = "EMSUEMACTV";

        /// <summary>
        /// EMSUEMSTAT.
        /// </summary>
        public const string EMSUEMSTAT = "EMSUEMSTAT";

        /// <summary>
        /// EMSUNOTYPE.
        /// </summary>
        public const string EMSUNOTYPE = "EMSUNOTYPE";

        /// <summary>
        /// EMSUNOSRC.
        /// </summary>
        public const string EMSUNOSRC = "EMSUNOSRC";

        /// <summary>
        /// EMSUF1CHAR.
        /// </summary>
        public const string EMSUF1CHAR = "EMSUF1CHAR";

        /// <summary>
        /// EMSUF2CHAR.
        /// </summary>
        public const string EMSUF2CHAR = "EMSUF2CHAR";

        /// <summary>
        /// EMSUF1NUM.
        /// </summary>
        public const string EMSUF1NUM = "EMSUF1NUM";

        /// <summary>
        /// EMSUF2NUM.
        /// </summary>
        public const string EMSUF2NUM = "EMSUF2NUM";

        /// <summary>
        /// EMSUF1STR.
        /// </summary>
        public const string EMSUF1STR = "EMSUF1STR";

        /// <summary>
        /// EMSUF2STR.
        /// </summary>
        public const string EMSUF2STR = "EMSUF2STR";

        /// <summary>
        /// EMSUFDATE.
        /// </summary>
        public const string EMSUFDATE = "EMSUFDATE";

        /// <summary>
        /// EMSUFTIME.
        /// </summary>
        public const string EMSUFTIME = "EMSUFTIME";

        /// <summary>
        /// EMJOBN.
        /// </summary>
        public const string EMJOBN = "EMJOBN";

        /// <summary>
        /// EMUSER.
        /// </summary>
        public const string EMUSER = "EMUSER";

        /// <summary>
        /// EMUPMJ.
        /// </summary>
        public const string EMUPMJ = "EMUPMJ";

        /// <summary>
        /// EMUPMT.
        /// </summary>
        public const string EMUPMT = "EMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F96409";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EMESUP", "EMESUP", JdeDataType.String, 20, true, true),
        new JdeField("EMSUTYPE", "EMSUTYPE", JdeDataType.String, 4, true, true),
        new JdeField("EMHOSTTYPE", "EMHOSTTYPE", JdeDataType.String, 4, true, true),
        new JdeField("EMSUEMAIL", "EMSUEMAIL", JdeDataType.String, 510, true, true),
        new JdeField("EMSUEMACTV", "EMSUEMACTV", JdeDataType.String, 2),
        new JdeField("EMSUEMSTAT", "EMSUEMSTAT", JdeDataType.String, 2),
        new JdeField("EMSUNOTYPE", "EMSUNOTYPE", JdeDataType.String, 4),
        new JdeField("EMSUNOSRC", "EMSUNOSRC", JdeDataType.String, 80),
        new JdeField("EMSUF1CHAR", "EMSUF1CHAR", JdeDataType.String, 2),
        new JdeField("EMSUF2CHAR", "EMSUF2CHAR", JdeDataType.String, 2),
        new JdeField("EMSUF1NUM", "EMSUF1NUM", JdeDataType.Numeric),
        new JdeField("EMSUF2NUM", "EMSUF2NUM", JdeDataType.Numeric),
        new JdeField("EMSUF1STR", "EMSUF1STR", JdeDataType.String, 20),
        new JdeField("EMSUF2STR", "EMSUF2STR", JdeDataType.String, 60),
        new JdeField("EMSUFDATE", "EMSUFDATE", JdeDataType.Numeric),
        new JdeField("EMSUFTIME", "EMSUFTIME", JdeDataType.Numeric),
        new JdeField("EMJOBN", "EMJOBN", JdeDataType.String, 20),
        new JdeField("EMUSER", "EMUSER", JdeDataType.String, 20),
        new JdeField("EMUPMJ", "EMUPMJ", JdeDataType.Numeric),
        new JdeField("EMUPMT", "EMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F96409_0", "Primary Key on EMESUP, EMSUTYPE, EMHOSTTYPE, EMSUEMAIL", new[] { "EMESUP", "EMSUTYPE", "EMHOSTTYPE", "EMSUEMAIL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F96409_2", "Index on EMESUP, EMSUTYPE, EMHOSTTYPE, EMSUEMACTV", new[] { "EMESUP", "EMSUTYPE", "EMHOSTTYPE", "EMSUEMACTV" }),
        new JdeIndex("F96409_3", "Index on EMESUP, EMSUTYPE, EMHOSTTYPE, EMSUNOSRC", new[] { "EMESUP", "EMSUTYPE", "EMHOSTTYPE", "EMSUNOSRC" })
    };
}
