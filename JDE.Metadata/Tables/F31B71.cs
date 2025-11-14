using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B71 - .
/// </summary>
public class F31B71 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VVWOPID.
        /// </summary>
        public const string VVWOPID = "VVWOPID";

        /// <summary>
        /// VVWV2VLNID.
        /// </summary>
        public const string VVWV2VLNID = "VVWV2VLNID";

        /// <summary>
        /// VVWFROMVID.
        /// </summary>
        public const string VVWFROMVID = "VVWFROMVID";

        /// <summary>
        /// VVWTOVID.
        /// </summary>
        public const string VVWTOVID = "VVWTOVID";

        /// <summary>
        /// VVWPLVLMV.
        /// </summary>
        public const string VVWPLVLMV = "VVWPLVLMV";

        /// <summary>
        /// VVWACTVLMV.
        /// </summary>
        public const string VVWACTVLMV = "VVWACTVLMV";

        /// <summary>
        /// VVWVUM.
        /// </summary>
        public const string VVWVUM = "VVWVUM";

        /// <summary>
        /// VVWPCTVLMV.
        /// </summary>
        public const string VVWPCTVLMV = "VVWPCTVLMV";

        /// <summary>
        /// VVWFB4LOTN.
        /// </summary>
        public const string VVWFB4LOTN = "VVWFB4LOTN";

        /// <summary>
        /// VVWFAFLOTN.
        /// </summary>
        public const string VVWFAFLOTN = "VVWFAFLOTN";

        /// <summary>
        /// VVWTB4LOTN.
        /// </summary>
        public const string VVWTB4LOTN = "VVWTB4LOTN";

        /// <summary>
        /// VVWTAFLOTN.
        /// </summary>
        public const string VVWTAFLOTN = "VVWTAFLOTN";

        /// <summary>
        /// VVWOVQ.
        /// </summary>
        public const string VVWOVQ = "VVWOVQ";

        /// <summary>
        /// VVWOVP.
        /// </summary>
        public const string VVWOVP = "VVWOVP";

        /// <summary>
        /// VVWAM.
        /// </summary>
        public const string VVWAM = "VVWAM";

        /// <summary>
        /// VVWMOF.
        /// </summary>
        public const string VVWMOF = "VVWMOF";

        /// <summary>
        /// VVWMOQ.
        /// </summary>
        public const string VVWMOQ = "VVWMOQ";

        /// <summary>
        /// VVWMIF.
        /// </summary>
        public const string VVWMIF = "VVWMIF";

        /// <summary>
        /// VVWMIQ.
        /// </summary>
        public const string VVWMIQ = "VVWMIQ";

        /// <summary>
        /// VVUSER.
        /// </summary>
        public const string VVUSER = "VVUSER";

        /// <summary>
        /// VVPID.
        /// </summary>
        public const string VVPID = "VVPID";

        /// <summary>
        /// VVJOBN.
        /// </summary>
        public const string VVJOBN = "VVJOBN";

        /// <summary>
        /// VVUPMJ.
        /// </summary>
        public const string VVUPMJ = "VVUPMJ";

        /// <summary>
        /// VVTDAY.
        /// </summary>
        public const string VVTDAY = "VVTDAY";

        /// <summary>
        /// VVWAACTVLM.
        /// </summary>
        public const string VVWAACTVLM = "VVWAACTVLM";

        /// <summary>
        /// VVCACR2.
        /// </summary>
        public const string VVCACR2 = "VVCACR2";
    }

    /// <inheritdoc />
    public override string TableName => "F31B71";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VVWOPID", "VVWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("VVWV2VLNID", "VVWV2VLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("VVWFROMVID", "VVWFROMVID", JdeDataType.Numeric),
        new JdeField("VVWTOVID", "VVWTOVID", JdeDataType.Numeric),
        new JdeField("VVWPLVLMV", "VVWPLVLMV", JdeDataType.Numeric),
        new JdeField("VVWACTVLMV", "VVWACTVLMV", JdeDataType.Numeric),
        new JdeField("VVWVUM", "VVWVUM", JdeDataType.String, 6),
        new JdeField("VVWPCTVLMV", "VVWPCTVLMV", JdeDataType.Numeric),
        new JdeField("VVWFB4LOTN", "VVWFB4LOTN", JdeDataType.String, 60),
        new JdeField("VVWFAFLOTN", "VVWFAFLOTN", JdeDataType.String, 60),
        new JdeField("VVWTB4LOTN", "VVWTB4LOTN", JdeDataType.String, 60),
        new JdeField("VVWTAFLOTN", "VVWTAFLOTN", JdeDataType.String, 60),
        new JdeField("VVWOVQ", "VVWOVQ", JdeDataType.String, 2),
        new JdeField("VVWOVP", "VVWOVP", JdeDataType.String, 2),
        new JdeField("VVWAM", "VVWAM", JdeDataType.String, 2),
        new JdeField("VVWMOF", "VVWMOF", JdeDataType.String, 2),
        new JdeField("VVWMOQ", "VVWMOQ", JdeDataType.Numeric),
        new JdeField("VVWMIF", "VVWMIF", JdeDataType.String, 2),
        new JdeField("VVWMIQ", "VVWMIQ", JdeDataType.Numeric),
        new JdeField("VVUSER", "VVUSER", JdeDataType.String, 20),
        new JdeField("VVPID", "VVPID", JdeDataType.String, 20),
        new JdeField("VVJOBN", "VVJOBN", JdeDataType.String, 20),
        new JdeField("VVUPMJ", "VVUPMJ", JdeDataType.Numeric),
        new JdeField("VVTDAY", "VVTDAY", JdeDataType.Numeric),
        new JdeField("VVWAACTVLM", "VVWAACTVLM", JdeDataType.Numeric),
        new JdeField("VVCACR2", "VVCACR2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B71_0", "Primary Key on VVWOPID, VVWV2VLNID", new[] { "VVWOPID", "VVWV2VLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B71_2", "Index on VVWOPID, VVWFROMVID", new[] { "VVWOPID", "VVWFROMVID" }),
        new JdeIndex("F31B71_3", "Index on VVWOPID, VVWTOVID", new[] { "VVWOPID", "VVWTOVID" })
    };
}
