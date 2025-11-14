using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46R010 - .
/// </summary>
public class F46R010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDEFFDATE.
        /// </summary>
        public const string SDEFFDATE = "SDEFFDATE";

        /// <summary>
        /// SDEPCHDR.
        /// </summary>
        public const string SDEPCHDR = "SDEPCHDR";

        /// <summary>
        /// SDEPCCFG.
        /// </summary>
        public const string SDEPCCFG = "SDEPCCFG";

        /// <summary>
        /// SDEPCMLV.
        /// </summary>
        public const string SDEPCMLV = "SDEPCMLV";

        /// <summary>
        /// SDLEN1.
        /// </summary>
        public const string SDLEN1 = "SDLEN1";

        /// <summary>
        /// SDLEN2.
        /// </summary>
        public const string SDLEN2 = "SDLEN2";

        /// <summary>
        /// SDLEN3.
        /// </summary>
        public const string SDLEN3 = "SDLEN3";

        /// <summary>
        /// SDURCD.
        /// </summary>
        public const string SDURCD = "SDURCD";

        /// <summary>
        /// SDURDT.
        /// </summary>
        public const string SDURDT = "SDURDT";

        /// <summary>
        /// SDURRF.
        /// </summary>
        public const string SDURRF = "SDURRF";

        /// <summary>
        /// SDTDAY.
        /// </summary>
        public const string SDTDAY = "SDTDAY";

        /// <summary>
        /// SDDTECRT.
        /// </summary>
        public const string SDDTECRT = "SDDTECRT";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDCTID.
        /// </summary>
        public const string SDCTID = "SDCTID";

        /// <summary>
        /// SDSVRNAME.
        /// </summary>
        public const string SDSVRNAME = "SDSVRNAME";
    }

    /// <inheritdoc />
    public override string TableName => "F46R010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDEFFDATE", "SDEFFDATE", JdeDataType.Numeric, null, true, true),
        new JdeField("SDEPCHDR", "SDEPCHDR", JdeDataType.String, 4),
        new JdeField("SDEPCCFG", "SDEPCCFG", JdeDataType.String, 4),
        new JdeField("SDEPCMLV", "SDEPCMLV", JdeDataType.String, 4),
        new JdeField("SDLEN1", "SDLEN1", JdeDataType.Numeric),
        new JdeField("SDLEN2", "SDLEN2", JdeDataType.Numeric),
        new JdeField("SDLEN3", "SDLEN3", JdeDataType.Numeric),
        new JdeField("SDURCD", "SDURCD", JdeDataType.String, 4),
        new JdeField("SDURDT", "SDURDT", JdeDataType.Numeric),
        new JdeField("SDURRF", "SDURRF", JdeDataType.String, 30),
        new JdeField("SDTDAY", "SDTDAY", JdeDataType.Numeric),
        new JdeField("SDDTECRT", "SDDTECRT", JdeDataType.Numeric),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDCTID", "SDCTID", JdeDataType.String, 30),
        new JdeField("SDSVRNAME", "SDSVRNAME", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46R010_0", "Primary Key on SDEFFDATE", new[] { "SDEFFDATE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46R010_2", "Index on SDEPCHDR", new[] { "SDEPCHDR" })
    };
}
