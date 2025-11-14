using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B34 - .
/// </summary>
public class F31B34 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STSITEM.
        /// </summary>
        public const string STSITEM = "STSITEM";

        /// <summary>
        /// STSDESC.
        /// </summary>
        public const string STSDESC = "STSDESC";

        /// <summary>
        /// STSTYPE.
        /// </summary>
        public const string STSTYPE = "STSTYPE";

        /// <summary>
        /// STSDATA.
        /// </summary>
        public const string STSDATA = "STSDATA";

        /// <summary>
        /// STSVALUE.
        /// </summary>
        public const string STSVALUE = "STSVALUE";

        /// <summary>
        /// STSWEM.
        /// </summary>
        public const string STSWEM = "STSWEM";

        /// <summary>
        /// STSBMETH.
        /// </summary>
        public const string STSBMETH = "STSBMETH";

        /// <summary>
        /// STSTVP.
        /// </summary>
        public const string STSTVP = "STSTVP";

        /// <summary>
        /// STSBVHC.
        /// </summary>
        public const string STSBVHC = "STSBVHC";

        /// <summary>
        /// STVBTSM.
        /// </summary>
        public const string STVBTSM = "STVBTSM";

        /// <summary>
        /// STVBTSTP.
        /// </summary>
        public const string STVBTSTP = "STVBTSTP";

        /// <summary>
        /// STVBTBVHC.
        /// </summary>
        public const string STVBTBVHC = "STVBTBVHC";

        /// <summary>
        /// STINSTYLE.
        /// </summary>
        public const string STINSTYLE = "STINSTYLE";

        /// <summary>
        /// STSUBSTYLE.
        /// </summary>
        public const string STSUBSTYLE = "STSUBSTYLE";

        /// <summary>
        /// STSTYLEPAR.
        /// </summary>
        public const string STSTYLEPAR = "STSTYLEPAR";

        /// <summary>
        /// STURCD.
        /// </summary>
        public const string STURCD = "STURCD";

        /// <summary>
        /// STURDT.
        /// </summary>
        public const string STURDT = "STURDT";

        /// <summary>
        /// STURAT.
        /// </summary>
        public const string STURAT = "STURAT";

        /// <summary>
        /// STURRF.
        /// </summary>
        public const string STURRF = "STURRF";

        /// <summary>
        /// STURAB.
        /// </summary>
        public const string STURAB = "STURAB";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";

        /// <summary>
        /// STSTCC01.
        /// </summary>
        public const string STSTCC01 = "STSTCC01";

        /// <summary>
        /// STSTCC02.
        /// </summary>
        public const string STSTCC02 = "STSTCC02";

        /// <summary>
        /// STSTYLEDT.
        /// </summary>
        public const string STSTYLEDT = "STSTYLEDT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B34";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STSITEM", "STSITEM", JdeDataType.String, 24, true, true),
        new JdeField("STSDESC", "STSDESC", JdeDataType.String, 60),
        new JdeField("STSTYPE", "STSTYPE", JdeDataType.String, 6),
        new JdeField("STSDATA", "STSDATA", JdeDataType.String, 6),
        new JdeField("STSVALUE", "STSVALUE", JdeDataType.Numeric),
        new JdeField("STSWEM", "STSWEM", JdeDataType.String, 6),
        new JdeField("STSBMETH", "STSBMETH", JdeDataType.String, 6),
        new JdeField("STSTVP", "STSTVP", JdeDataType.Numeric),
        new JdeField("STSBVHC", "STSBVHC", JdeDataType.String, 6),
        new JdeField("STVBTSM", "STVBTSM", JdeDataType.String, 6),
        new JdeField("STVBTSTP", "STVBTSTP", JdeDataType.Numeric),
        new JdeField("STVBTBVHC", "STVBTBVHC", JdeDataType.String, 6),
        new JdeField("STINSTYLE", "STINSTYLE", JdeDataType.String, 2),
        new JdeField("STSUBSTYLE", "STSUBSTYLE", JdeDataType.String, 2),
        new JdeField("STSTYLEPAR", "STSTYLEPAR", JdeDataType.String, 24),
        new JdeField("STURCD", "STURCD", JdeDataType.String, 4),
        new JdeField("STURDT", "STURDT", JdeDataType.Numeric),
        new JdeField("STURAT", "STURAT", JdeDataType.Numeric),
        new JdeField("STURRF", "STURRF", JdeDataType.String, 30),
        new JdeField("STURAB", "STURAB", JdeDataType.Numeric),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric),
        new JdeField("STSTCC01", "STSTCC01", JdeDataType.String, 6),
        new JdeField("STSTCC02", "STSTCC02", JdeDataType.String, 6),
        new JdeField("STSTYLEDT", "STSTYLEDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B34_0", "Primary Key on STSITEM", new[] { "STSITEM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B34_2", "Index on STSTYLEPAR", new[] { "STSTYLEPAR" })
    };
}
